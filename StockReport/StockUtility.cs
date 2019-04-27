// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.StockReport
{
    using System;

    /// <summary>
    /// Stock Utility
    /// </summary>
    public class StockUtility
    {
        /// <summary>
        /// Prints the stock report.
        /// </summary>
        /// <param name="stock">The stock.</param>
        /// <param name="totalShareCost">The total share cost.</param>
        public void PrintStockReport(Stock[] stock, double totalShareCost)
        {
            ////Print the stock report
            for (int i = 1; i <= stock.Length; i++)
            {
                Console.WriteLine("\nStock {0} : \n", i);
                Console.WriteLine("\nStock Name          : {0}", stock[i].StockName);
                Console.WriteLine("\nNumber of shares    : {0}", stock[i].NumberOfShares);
                Console.WriteLine("\nPrice of each share : {0}", stock[i].SharePrice);
                Console.WriteLine("\nTotal share price   : {0}", stock[i].SharePrice * stock[i].NumberOfShares);

                ////Calculate the total price of all stock
                totalShareCost += stock[i].SharePrice * stock[i].NumberOfShares;
            }

            Console.WriteLine("\nTotal Cost Of All Stock is : {0} ", totalShareCost);
        }
    }
}
