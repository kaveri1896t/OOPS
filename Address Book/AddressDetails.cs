// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressDetails.cs" company="Bridgelabz">
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
    /// Address Details 
    /// </summary>
    public class AddressDetails
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// The zip
        /// </summary>
        private string zip;

        /// <summary>
        /// The phone number
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressDetails"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        public AddressDetails(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string Zip
        {
            get { return this.zip; }
            set { this.zip = value; }
        }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        /// <summary>
        /// Creates the address details.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="phoneNumber">The phone number.</param>
        public static void CreateAddressDetails(string bookName, string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber)
        {
            ////creating a object of addresDetails
            AddressDetails addressDetails = new AddressDetails(firstName, lastName, address, city, state, zip, phoneNumber);

            //// Getting the AddressBook and adding the newly created object in list.
            AddressBook addressBook = Input.GetBookDetails(bookName);
            addressBook.AddressDetailsList.Add(addressDetails);
            Input.WriteAddressBookToFile(addressBook);
            Console.WriteLine("Added to AddressBook " + bookName);
        }

        /// <summary>
        /// Gets the first name list.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <returns>returns the List of firstNames</returns>
        public static List<string> GetFirstNameList(string bookName)
        {
            AddressBook addressBook = Input.GetBookDetails(bookName);
            List<string> firstNameList = new List<string>();

            List<AddressDetails> list = addressBook.AddressDetailsList;

            foreach (AddressDetails address in list)
            {
                firstNameList.Add(address.FirstName);
            }

            return firstNameList;
        }

        /// <summary>
        /// Does the name exist.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="name">The name.</param>
        /// <returns>returns true or false</returns>
        public static bool DoesNameExist(string bookName, string name)
        {
            AddressBook addressBook = Input.GetBookDetails(bookName);
            List<AddressDetails> list = addressBook.AddressDetailsList;

            ////loops over all the Addressdetail to find wheather given name exist.
            foreach (AddressDetails address in list)
            {
                if (address.FirstName.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Name : " + this.FirstName + " " + this.LastName + "\nAddress : " + this.Address + "\nCity : " + this.City + "\nState : " + this.State + "\nZip  : " + this.Zip + "\nPhone Number : " + this.phoneNumber;
        }
    }
}
