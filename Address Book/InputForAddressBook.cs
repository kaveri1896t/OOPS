// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForAddressBook.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Address_Book
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Take inputs from user
    /// </summary>
    public class InputForAddressBook
    {
        /// <summary>
        /// Takes the input for address book.
        /// </summary>
        /// <returns>returns string</returns>
        public static string TakeInputForAddressBook()
        {
            string addressBookName = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter a Name for Address Book");
                addressBookName = Console.ReadLine();

                if (InventoryManagement.InventoryMngtUtility.CheckString(addressBookName))
                {
                    Console.WriteLine("You have to Specify a name");
                    continue;
                }

                if (InventoryManagement.InventoryMngtUtility.ContainsCharacter(addressBookName))
                {
                    Console.WriteLine("No Special Characters allowed");
                    continue;
                }

                return addressBookName;
            }
        }
    }
}
