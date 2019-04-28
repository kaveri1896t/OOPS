// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterfaceStockAccount.cs" company="Bridgelabz">
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
    /// Interface fro Stock account
    /// </summary>
    public interface InterfaceStockAccount
    {
        /// <summary>
        /// Buys the specified number of shares.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="price">The price.</param>
        /// <param name="symbol">The symbol.</param>
        void Buy(long numberOfShares, double price, string symbol);

        /// <summary>
        /// Prints the report.
        /// </summary>
        void PrintReport();

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void Save(string fileName);

        /// <summary>
        /// Sells the specified symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>     
        void Sell(string symbol);

        /// <summary>
        /// Values the of.
        /// </summary>
        /// <returns>returns double</returns>
        double ValueOf();

        /// <summary>
        /// Stock account the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void Stockaccount(string fileName);

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        void PrintSymbols();
    }
}
