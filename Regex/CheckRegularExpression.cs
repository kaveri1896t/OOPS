// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckRegularExpression.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Regex
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// To check if the input given by the user is in Correct format
    /// </summary>
    public class CheckRegularExpression
    {
        /// <summary>
        /// The user details is an instance of User details class to access members
        /// </summary>
        private UserDetails userDetails = new UserDetails();

        /// <summary>
        /// The utility is an instance of Utility class to access members
        /// </summary>
        private RegexUtility utility = new RegexUtility();

        /// <summary>
        /// Get input and pass it to replace with pattern
        /// </summary>
        public void RegularExpression()
        {
            ////Get input from user and validate the format
            userDetails = utility.GetInput(userDetails);

            ////Spilt the fist name and last name
            string[] nameArray = userDetails.FullName.Split(" ");

            ////Call function to replace all string by its pattern
            utility.ReplaceByPattern(nameArray[0], userDetails.FullName, userDetails.ContactNumber);
        }
    }
}
