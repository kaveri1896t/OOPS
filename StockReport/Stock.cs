// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stock.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.StockReport
{
    using System;

    /// <summary>
    /// Class stock to read stock from file and Calculate total share price 
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// The name of the stock
        /// </summary>
        private string stockName;

        /// <summary>
        /// The number of shares
        /// </summary>
        private long numberOfShares;

        /// <summary>
        /// The price of each share
        /// </summary>
        private double sharePrice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="stockName">Name of the stock.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="sharePrice">The share price.</param>
        public Stock(string stockName, long numberOfShares, double sharePrice)
        {
            this.stockName = stockName;
            this.numberOfShares = numberOfShares;
            this.sharePrice = sharePrice;
        }

        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName
        {
            get
            {
                return this.stockName;
            }

            set
            {
                this.stockName = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of shares.
        /// </summary>
        /// <value>
        /// The number of shares.
        /// </value>
        public long NumberOfShares
        {
            get
            {
                return this.numberOfShares;
            }

            set
            {
                this.numberOfShares = value;
            }
        }

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public double SharePrice
        {
            get
            {
                return this.sharePrice;
            }

            set
            {
                this.sharePrice = value;
            }
        }
    }
}
