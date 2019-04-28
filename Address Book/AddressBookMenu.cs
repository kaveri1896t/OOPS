// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookMenu.cs" company="Bridgelabz">
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
    /// Menu for address book
    /// </summary>
    public class AddressBookMenu
    {
        /// <summary>
        /// Address book the view.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        public static void AddressbookView(string bookName)
        {
            int option = 0;
            while (true)
            {
                Console.WriteLine("Choose what you want to do with AdressBook " + bookName + ".");
                Console.WriteLine("Press 0) To Go Back");
                Console.WriteLine("press 1) To Open the BookDetails");
                Console.WriteLine("Press 2) To Add Address");
                Console.WriteLine("Press 3) To Edit an Address");
                Console.WriteLine("Press 4) To Sort the " + bookName + " book details By Last Name");
                Console.WriteLine("Press 5) To Sort the " + bookName + " book details By Zip");

                string stringOption = Console.ReadLine();

                try
                {
                    option = Convert.ToInt32(stringOption);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                ////calls the Method based on the Option Choosen.
                switch (option)
                {
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            AddressBook.PrintAddressBookDetails(bookName);
                            break;
                        }

                    case 2:
                        {
                            InputForAddressDetails.TakeInputForAddress(bookName);
                            break;
                        }

                    case 3:
                        {
                            AddressDetailsManipulationMenu.EditDetails(bookName);
                            break;
                        }

                    case 4:
                        {
                            AddressDetailsManipulation.SortByLastName(bookName);
                            break;
                        }

                    case 5:
                        {
                            AddressDetailsManipulation.SortByZip(bookName);
                            break;
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
