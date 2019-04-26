// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForRegex.cs" company="Bridgelabz">
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
    /// Takes input from user
    /// </summary>
    public class RegexUtility
    {
        /// <summary>
        /// Gets the input from user.
        /// </summary>
        public UserDetails GetInput(UserDetails userDetails)
        {
            try
            {
                ////Validate the user input
                do
                {
                    ////Take the full name from user
                    Console.WriteLine("Enter the valid full name (first name, last name seperated by single space) : ");
                    userDetails.FullName = Console.ReadLine();
                }
                while (Regex.IsMatch(userDetails.FullName, "^[a-zA-z]+//s+[a-zA-Z]+$"));

                do
                {
                    ////Take the contact number from user
                    Console.WriteLine("Enter the Mobile number (10 digits) : ");
                    userDetails.ContactNumber = Console.ReadLine();
                }
                while (Regex.IsMatch(userDetails.ContactNumber, "^[0-9]{10}$"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return userDetails;
        }

        /// <summary>
        /// Replaces the objects by its specified patterns.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fullName">The full name.</param>
        /// <param name="contactNumber">The contact number.</param>
        public void ReplaceByPattern(string name, string fullName, string contactNumber)
        {
            ////Messsage to be displayed by replacing the patterns
            string message = "\nHello <<name>>, " +
                             "\nWe have your full name as <<full name>> in our system. " +
                             "\nYour contact number is 91-<<xxxxxxxxxx>>. " +
                             "\nPlease, let us know in case of any clarification. " +
                             "\nThank you... " +
                             "\n                    BridgeLabz <<XX/XX/XXXX>>.";
            string namePattern = "<<name>>";
            string fullNamePattern = "<<full name>>";
            string contactPattern = "<<xxxxxxxxxx>>";
            string datePattern = "<<XX/XX/XXXX>>";

            ////Take current time of system
            string date = DateTime.Now.ToShortDateString();

            ////Replace the message with user details
            message = Regex.Replace(message, namePattern, name);
            message = Regex.Replace(message, fullNamePattern, fullName);
            message = Regex.Replace(message, contactPattern, contactNumber);
            message = Regex.Replace(message, datePattern, date);

            ////Print the replaced message
            Console.WriteLine(message);
            return;
        }
    }
}
