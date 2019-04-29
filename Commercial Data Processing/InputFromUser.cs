// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputFromUser.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Commercial_Data_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Take input from user 
    /// </summary>
    public class InputFromUser
    {
        /// <summary>
        /// Takes the user input.
        /// </summary>
        /// <param name="choosedOption">The option.</param>
        public static void TakeUserInput(int choosedOption)
        {
            StockAccount stockAccount = new StockAccount();
            int numberOfShares = 0;
            double priceOfShare = 0;
            string symbol = string.Empty;
            string datetime = string.Empty;
            string stringNumberOfShares;
            if (choosedOption == 1)
            {
                do
                {
                    Console.WriteLine("Enter the Number of shares");
                    stringNumberOfShares = Console.ReadLine();
                }
                while (!InventoryManagement.InventoryMngtUtility.IsNumber(stringNumberOfShares));

                while (true)
                {
                    Console.WriteLine("Enter the Price Of Share");
                    string stringpriceOfShare = Console.ReadLine();
                    if (InventoryManagement.InventoryMngtUtility.IsNumber(stringpriceOfShare) == false)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    priceOfShare = Convert.ToInt32(stringpriceOfShare);
                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the Stock Symbol");
                    string stringSymbol = Console.ReadLine();
                    if (InventoryManagement.InventoryMngtUtility.CheckString(stringSymbol))
                    {
                        Console.WriteLine("Stock Symbol can't be empty");
                        continue;
                    }

                    if (InventoryManagement.InventoryMngtUtility.ContainsCharacter(stringSymbol))
                    {
                        Console.WriteLine("No characters allowed");
                        continue;
                    }

                    symbol = stringSymbol;
                    break;
                }

                stockAccount.Buy(numberOfShares, priceOfShare, symbol);
            }

            if (choosedOption == 2)
            {
                while (true)
                {
                    Console.WriteLine("Enter the Stock Symbol of the share you want to sell");
                    string stringSymbol = Console.ReadLine();
                    if (InventoryManagement.InventoryMngtUtility.CheckString(stringSymbol))
                    {
                        Console.WriteLine("Stock Symbol cant be empty");
                        continue;
                    }

                    symbol = stringSymbol;
                    stockAccount.Sell(symbol);
                    break;
                }
            }
        }
    }
}
