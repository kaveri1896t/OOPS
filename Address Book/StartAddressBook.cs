// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartAddressBook.cs" company="Bridgelabz">
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
    /// Execution start of address book 
    /// </summary>
    public class StartAddressBook
    {
        /// <summary>
        /// Initialize the address book.
        /// </summary>
        public void InitialiseAddressBook()
        {
            int option = 0;

            while (true)
            {
                Console.WriteLine("1.View Existing Address Book");
                Console.WriteLine("2.Create new Address  book");
                string stringOption = Console.ReadLine();

                ///
                if (InventoryManagement.InventoryMngtUtility.CheckString(stringOption))
                {
                    Console.WriteLine("Invalid Option choosen");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

                ////calls the method Based on the Option Choosen.
                switch (option)
                {
                    case 1:
                        {
                            AddressBook.PrintExistingAddressBook();
                            break;
                        }

                    case 2:
                        {
                            string addressBookname = InputForAddressBook.TakeInputForAddressBook();
                            AddressBook.CreateAddressBook(addressBookname);
                            break;
                        }

                    case 3:
                        {
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            }
        }
    }
}
