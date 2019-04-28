// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCardQueue.cs" company="Bridgelabz">
// Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.CardsQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public class DeckOfCardQueue
    {
        /// <summary>
        /// The deck of cards
        /// </summary>
        internal int[,] deckOfcardArray = new int[4, 13];

        /// <summary>
        /// The player is set to 1
        /// </summary>
        internal int player = 1;

        /// <summary>
        /// Gets the suits.
        /// </summary>
        /// <param name="suits">The suits.</param>
        /// <returns> returns suit</returns>
        public static string GetSuit(int suits)
        {
            switch (suits)
            {
                case 0:
                    return "Clubs";

                case 1:
                    return "Diamond";

                case 2:
                    return "Heart";

                case 3:
                    return "Spade";

                default:
                    return "In (default)";
            }
        }

        /// <summary>
        /// Gets the rank of the player.
        /// </summary>
        /// <param name="rank">The rank.</param>
        /// <returns> returns rank</returns>
        public static string GetRank(int rank)
        {
            switch (rank)
            {
                case 0:
                    return "2";

                case 1:
                    return "3";

                case 2:
                    return "4";

                case 3:
                    return "5";

                case 4:
                    return "6";

                case 5:
                    return "7";

                case 6:
                    return "8";

                case 7:
                    return "9";

                case 8:
                    return "10";

                case 9:
                    return "Jack";

                case 10:
                    return "Queen";

                case 11:
                    return "King";

                case 12:
                    return "Ace";

                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Starts the game by calling the method.
        /// </summary>
        public void StartGame()
        {
            ////Create instance of deck utility class
            Deck_Of_Cards.DeckUtility deckUtility = new Deck_Of_Cards.DeckUtility();
            deckUtility.InitializeDeckOfCards();
        }
    }
}
