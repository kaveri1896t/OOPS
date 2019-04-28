// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartCommercial.cs" company="Bridgelabz">
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
    /// Execution start for commercial data processing 
    /// </summary>
    public class StartCommercial
    {
        /// <summary>
        /// Starts  the shares.
        /// </summary>
        public void InitialiseShares()
        {
            StockAccount stockAccount = new StockAccount();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1.To buy Share");
                Console.WriteLine("2.To Sell a Share");
                Console.WriteLine("3.To view Existing Shares");
                Console.WriteLine("4.View Stock Symobol Purchased");

                string stringOption = Console.ReadLine();

                if (InventoryManagement.InventoryMngtUtility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                int option = Convert.ToInt32(stringOption);

                //// Calls the method based on choosen option by the user.
                switch (option)
                {
                    case 1:
                        InputFromUser.TakeUserInput(option);
                        break;

                    case 2:
                        InputFromUser.TakeUserInput(option);
                        break;

                    case 3:
                        stockAccount.PrintReport();
                        break;

                    case 4:
                        StockAccount stockaccount = new StockAccount();
                        stockaccount.PrintSymbols();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        return;
                }
            }
        }
    }
}
