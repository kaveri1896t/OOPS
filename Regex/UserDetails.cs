// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Regex
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Stores user details
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// The full name of the user (first last)
        /// </summary>
        private string fullName;

        /// <summary>
        /// The contact number of the user
        /// </summary>
        private string contactNumber;

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get
            {
                return this.fullName;
            }

            set
            {
                this.fullName = value;
            }
        }

        /// <summary>
        /// Gets or sets the contact number.
        /// </summary>
        /// <value>
        /// The contact number.
        /// </value>
        public string ContactNumber
        {
            get
            {
                return this.contactNumber;
            }

            set
            {
                this.contactNumber = value;
            }
        }
    }
}
