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

                if (!Regex.IsMatch(firstName, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                if (AddressDetails.DoesNameExist(bookName, firstName))
                {
                    Console.WriteLine("First name with" + firstName + " Already exist, please enter another name");
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the LastName");
                lastName = Console.ReadLine();

                if (!Regex.IsMatch(lastName, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the Address");
                address = Console.ReadLine();

                if (InventoryManagement.InventoryMngtUtility.CheckString(address))
                {
                    Console.WriteLine("Address Cant be Empty");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the City");
                city = Console.ReadLine();

                if (!Regex.IsMatch(city, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the State");
                state = Console.ReadLine();

                if (!Regex.IsMatch(state, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the Zip");
                zip = Console.ReadLine();

                if (!Regex.IsMatch(zip, "^[0-9]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters not allowed)");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the phoneNumber");
                phoneNumber = Console.ReadLine();

                if (!Regex.IsMatch(phoneNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                break;
            }

            AddressDetails.CreateAddressDetails(bookName, firstName, lastName, address, city, state, zip, phoneNumber);
        }
    }
}
