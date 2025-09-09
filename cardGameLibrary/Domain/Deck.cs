using System.ComponentModel;
using Domain.CardClass;
using Domain.GameClass;
using Domain.PlayerClass;

namespace Domain.DeckClass
{

    public class Deck
    {
        private readonly List<Cards> deck; // Card is the class from Card.cs
        

        public Deck() // constructor
        {
            deck = new List<Cards>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit))) // putting suit with values into list deck
            {
                for (int number = 1; number <= 8; number++)
                {
                    deck.Add(new Cards(suit, number)); // aadding them togeher here. 
                }
            }
        }


        // bruger fishers-yates shuffle algorithm
        public void Shuffle()
        {
            var range = new Random(); // starting random generator
            var n = deck.Count; // n = number of cards in deck
            for (int i = n - 1; i > 0; i--)
            {
                int j = range.Next(i + 1);
                var temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

        }


        public void DealtTo(Player player, int numberOfCards)
        {

            for (int i = 0; i < numberOfCards; i++)
            {
                var card = deck[0]; // take the top card
                deck.RemoveAt(0); // remove the top card from the deck
                player.AcceptCard(card); // give the card to the player

            }
            
        }

    }
}