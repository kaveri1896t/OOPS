// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForAddressDetails.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.Address_Book
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// take input from user
    /// </summary>
    public class InputForAddressDetails
    {
        /// <summary>
        /// Takes the input for address.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        public static void TakeInputForAddress(string bookName)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            string address = string.Empty;
            string city = string.Empty;
            string state = string.Empty;
            string zip = string.Empty;
            string phoneNumber = string.Empty;

            while (true)
            {
                Console.WriteLine("Enter the firstName");
                firstName = Console.ReadLine();

                ////check whether the user entered correct string
                if (!Regex.IsMatch(firstName, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Special Characters, numbers are not allowed...");
                    continue;
                }

                ////check whether the user entered correct string
                if (AddressDetails.DoesFileNameExist(bookName, firstName))
                {
                    Console.WriteLine("First name with" + firstName + " already exist, Please enter another name : ");
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the LastName");
                lastName = Console.ReadLine();

                ////check whether the user entered correct string
                if (!Regex.IsMatch(lastName, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Special Characters, numbers are not allowed...");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the Address");
                address = Console.ReadLine();

                ////check whether the user entered correct string
                if (InventoryManagement.InventoryMngtUtility.CheckString(address))
                {
                    Console.WriteLine("Address can't be Empty...");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the City");
                city = Console.ReadLine();

                ////check whether the user entered correct string
                if (!Regex.IsMatch(city, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Special Characters,number not allowed...");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the State");
                state = Console.ReadLine();

                ////check whether the user entered correct string
                if (!Regex.IsMatch(state, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Special Characters, number are not allowed...");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the Zip");
                zip = Console.ReadLine();

                ////check whether the user entered correct input
                if (!Regex.IsMatch(zip, "^[0-9]+$"))
                {
                    Console.WriteLine("Characters not allowed...");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the 10 digit Contact Number");
                phoneNumber = Console.ReadLine();

                ////check whether the user entered correct input
                if (!Regex.IsMatch(phoneNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Characters are not allowed");
                    continue;
                }

                break;
            }

            ////call to the create method for address book and pass inputs taken by the user
            AddressDetails.CreateAddressDetails(bookName, firstName, lastName, address, city, state, zip, phoneNumber);
        }
    }
}
