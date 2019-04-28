// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming
{
    using System;

    /// <summary>
    /// Menu for all programs
    /// Entry point of execution
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int choice;
            char answer;
            try
            {
                do
                {
                    Console.WriteLine("1.Inventory Details");
                    Console.WriteLine("2.Regular Expression");
                    Console.WriteLine("3.Stock Report");
                    Console.WriteLine("4.Inventory Management");
                    Console.WriteLine("5.Deck Of Cards");
                    Console.WriteLine("6.Deck Of Cards using queue");
                    Console.WriteLine("7.Commercial Data Processing");
                    Console.WriteLine("8.Address Book Details");
                    Console.WriteLine("\nEnter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Inventory.Inventory inventory = new Inventory.Inventory();
                            inventory.PrintTotalData();
                            break;

                        case 2:
                            Regex.CheckRegularExpression regularExpression = new Regex.CheckRegularExpression();
                            regularExpression.RegularExpression();
                            break;

                        case 3:
                            StockReport.StockPortfolio stockPortfolio = new StockReport.StockPortfolio();
                            stockPortfolio.StockReport();
                            break;

                        case 4:
                            InventoryManagement.FirstView.StartInventoryManager();
                            break;

                        case 5:
                            Deck_Of_Cards.DeckOfCards deckOfCards = new Deck_Of_Cards.DeckOfCards();
                            deckOfCards.StartGame();
                            break;

                        case 6:
                            CardsQueue.DeckOfCardQueue deckOfCardQueue = new CardsQueue.DeckOfCardQueue();
                            deckOfCardQueue.StartGame();
                            break;

                        case 7:
                            Commercial_Data_Processing.StartCommercial start = new Commercial_Data_Processing.StartCommercial();
                            start.InitialiseShares();
                            break;

                        case 8:
                            Address_Book.StartAddressBook startAddress = new Address_Book.StartAddressBook();
                            startAddress.InitialiseAddressBook();
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("\nDo you want to continue in Main Menu (y/n) : ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
                while (answer == 'y' || answer == 'Y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
