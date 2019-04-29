namespace Object_Oriented_Programming.Deck_Of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DeckUtility
    {
        /// <summary>
        /// The cards is an instance of the deck of cards
        /// </summary>
        private DeckOfCards cards = new DeckOfCards();

        /// <summary>
        /// The card list to store cards of player in queue
        /// </summary>
        internal List<int> CardList = new List<int>();

        /// <summary>
        /// The player list is the list of players
        /// </summary>
        internal List<int> PlayerList = new List<int>();

        /// <summary>
        /// The card queue is an object of card queue
        /// </summary>
        internal CardsQueue.CardQueue<int> cardQueue = new CardsQueue.CardQueue<int>();

        /// <summary>
        /// The list1 is an instance of Linked List
        /// </summary>
        internal CardsQueue.LinkedList1<int> list1 = new CardsQueue.LinkedList1<int>();

        /// <summary>
        /// Initializes the deck of cards.
        /// </summary>
        public void InitializeDeckOfCards()
        {
            ////for each player.
            for (int playerNumber = 1; playerNumber <= 4; playerNumber++)
            {
                ////Distribute cards to players
                this.Distribute9CardsEach(playerNumber);

                Console.WriteLine("player " + cards.player);
                cards.player++;
                Console.WriteLine("**************");

                ////Print the cards of each players
                this.Print(playerNumber);
                Console.WriteLine("**************");
            }
        }

        /// <summary>
        /// Initializes the deck of cards using queue.
        /// </summary>
        public void InitializeDeckOfCardsQueue()
        {
            for (int i = 1; i <= 4; i++)
            {
                PlayerList.Add(i);
            }

            ////Insert into queue
            foreach (int number in PlayerList)
            {
                ////Insert player into queue
                cardQueue.EnQueue(PlayerList, number);
            }

            ////Dequeue the players
            list1 = cardQueue.DeQueue(list1, PlayerList);

            ////Read data returned by the queue in list
            PlayerList = list1.ReadIntoList(list1);

            ////for each player.
            foreach (int playerNumber in PlayerList)
            {
                ////Distribute cards to players
                this.Distribute9CardsEach(playerNumber);
                Console.WriteLine("player " + cards.player);
                cards.player++;
                Console.WriteLine("**************");

                ////Print the cards of each players
                this.Print(playerNumber);
                Console.WriteLine("**************");
            }
            
        }

        /// <summary>
        /// Shuffles the cards.
        /// </summary>
        /// <param name="playerNumber">The player number.</param>
        public void ShuffleCards(int playerNumber)
        {
            ////Object of Random class
            Random random = new Random();

            ////generating a random Number for suit.
            int suit = random.Next(1, 4);

            ////generating a random Number for rank.
            int rank = random.Next(1, 13);

            ////check if is empty
            if (cards.deckOfcardArray[suit, rank] == 0)
            {
                ////Store player number into 2D array
                cards.deckOfcardArray[suit, rank] = playerNumber;
                return;
            }
            else
            {
                ////call recursively to shuffle cards
                this.ShuffleCards(playerNumber);
            }
        }

        /// <summary>
        /// Distribute9s the cards.
        /// </summary>
        /// <param name="playerNumber">The player number.</param>
        public void Distribute9CardsEach(int playerNumber)
        {
            //// iterate till get 9 cards to each player
            for (int i = 0; i < 9; i++)
            {
                ////Before distribute shuffle the cards
                this.ShuffleCards(playerNumber);
            } 
        }

        /// <summary>
        /// Prints the specified player number.
        /// </summary>
        /// <param name="playerNumber">The player number.</param>
        public void Print(int playerNumber)
        {
            int suitLength = cards.deckOfcardArray.GetLength(0);
            int rankLength = cards.deckOfcardArray.GetLength(1);
            for (int suits = 0; suits < suitLength; suits++)
            {
                for (int ranks = 0; ranks < rankLength; ranks++)
                {
                    ////If the cards are of given player then print it with rank
                    if (cards.deckOfcardArray[suits, ranks] == playerNumber)
                    {
                        Console.WriteLine(DeckOfCards.GetSuit(suits) + " " + DeckOfCards.GetRank(ranks));
                    }
                }
            }
        }
    }
}
