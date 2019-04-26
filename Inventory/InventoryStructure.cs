// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryStructure.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming
{
    using System;

    /// <summary>
    /// Creating Structure of the inventory
    /// </summary>
    public class InventoryStructure
    {
        /// <summary>
        /// The name of the product
        /// </summary>
        private string name;

        /// <summary>
        /// The weight of the product
        /// </summary>
        private double weight;

        /// <summary>
        /// The price per kg of the product
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Gets or sets the Price Per Kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            get { return this.pricePerKg; }
            set { this.pricePerKg = value; }
        }
    }
}
