// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.StockReport
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// class to read stock data from java script object notation file
    /// and calculate the total stock price
    /// </summary>
    public class StockPortfolio
    {
        /// <summary>
        /// The file path object
        /// </summary>
        private FilePaths filePath = new FilePaths();

        /// <summary>
        /// The stock utility to access the members
        /// </summary>
        private StockUtility stockUtility = new StockUtility();

        /// <summary>
        /// Generates the stock report.
        /// </summary>
        public void StockReport()
        {
            ////To calculate the total price of all stocks
            double totalShareCost = 0.0;
            try
            {
                ////Check if file exist 
                if (File.Exists(this.filePath.StockDetails))
                {
                    ////Read data from file
                    string readFromJson = File.ReadAllText(this.filePath.StockDetails);

                    ////Convert data from java script object notation to .Net 
                    Stock[] stock = JsonConvert.DeserializeObject<Stock[]>(readFromJson);

                    ////Print stock report
                    this.stockUtility.PrintStockReport(stock, totalShareCost);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
