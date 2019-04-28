// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming.Commercial_Data_Processing
{
    public class StockAccount:InterfaceStockAccount
    {
        /// <summary>
        /// The company shares list
        /// </summary>
        private CardsQueue.LinkedList1<CompanyShares> companySharesList = new CardsQueue.LinkedList1<CompanyShares>();

        /// <summary>
        /// Buys the specified number of shares.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="price">The price.</param>
        /// <param name="symbol">The symbol.</param>
        public void Buy(long numberOfShares, double price, string symbol)
        {
            List<CompanyShares> companySharesList = CommercialUtility.ReadFromFile();

            foreach (CompanyShares shares in companySharesList)
            {
                if (shares.Symbol.Equals(symbol))
                {
                    Console.WriteLine("You have already bought this share with symbol " + symbol);
                    return;
                }
            }

            string dateTime = DateTime.Now.ToString();
            CompanyShares companyShares = new CompanyShares(numberOfShares, price, symbol, dateTime);
            companySharesList.Add(companyShares);

            CommercialUtility.WriteToFile(companySharesList);
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public void PrintReport()
        {
            double totalValueOfAllStock = 0;
            List<CompanyShares> companySharesList = CommercialUtility.ReadFromFile();

            foreach (CompanyShares cs in companySharesList)
            {
                Console.WriteLine("\nStockName : " + cs.Symbol + "\nNumber of Shares: " + cs.NumberOfShares + "\nPrice Of each share: " + cs.PriceOfShare + "\nPurchased Date and Time : " + cs.DateTime);
                Console.WriteLine("\nTotal Value Of Stock " + cs.Symbol + ": " + (cs.NumberOfShares * cs.PriceOfShare));
                Console.WriteLine("--------------------------------");

                totalValueOfAllStock = totalValueOfAllStock + (cs.NumberOfShares * cs.PriceOfShare);
            }

            Console.WriteLine("\nTotal value Of all Stocks = " + totalValueOfAllStock);
        }

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException">Handles and throws Exception</exception>
        public void Save(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sells the specified symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public void Sell(string symbol)
        {
            List<CompanyShares> companySharesList = CommercialUtility.ReadFromFile();
            foreach (CompanyShares companyShares in companySharesList)
            {
                if (companyShares.Symbol.Equals(symbol))
                {
                    companySharesList.Remove(companyShares);
                    Console.WriteLine("Share with Symbol " + symbol + "removed");
                    CommercialUtility.WriteToFile(companySharesList);
                    return;
                }
            }

            Console.WriteLine("stock with Symbol " + symbol + "does not exist");
        }

        /// <summary>
        /// Values the of.
        /// </summary>
        /// <returns> double value</returns>
        /// <exception cref="NotImplementedException">Handles and throws Exception</exception>
        public double ValueOf()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stock account the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException"> Handles and throws Exception</exception>
        public void Stockaccount(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        public void PrintSymbols()
        {
            Stack symbolStack = CommercialUtility.ReadStockSymbols();

            Console.WriteLine("Your Currently purchased Symbols are ");

            while (!symbolStack.IsEmpty())
            {
                Console.Write(symbolStack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
