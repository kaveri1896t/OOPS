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
            try
            {
                StockAccount stockAccount = new StockAccount();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Buy the Share");
                    Console.WriteLine("2.Sell a Share");
                    Console.WriteLine("3.View Existing Shares");
                    Console.WriteLine("4.View Symobol Purchased");
                    string input = Console.ReadLine();

                    ////Check if the choice enterd by the user contains number
                    if (InventoryManagement.InventoryMngtUtility.IsNumber(input) == false)
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    ////convert that number to an integer type
                    int option = Convert.ToInt32(input);

                    //// Calls the method of user's choice
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
                            return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
