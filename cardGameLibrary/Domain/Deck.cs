using System.ComponentModel;
using Domain.Cards;
using Domain.Game;

namespace Domain.Deck
{

    public class Deck
    {
        private readonly List<Card> deck; // Card is the class from Card.cs
        private List<Player> player; // Player is the class from Player.cs
        

        public Deck(List<Card> Deck) // constructor
        {
            this.deck = Deck;

            foreach (Suit suit in Enum.GetValues(typeof(Suit))) // putting suit with values into list deck
            {
                for (int number = 1; number <= 8; number++)
                {
                    Deck.Add(new Card(suit, number)); // aadding them togeher here. 
                }
            }
        }


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


        public void DealtTo(List<Player> Player, int numberOfCards)
        {
            this.player = Player;

            for (int i = 0; i < numberOfCards; i++)
            {
                Player.Add();

            }
            
        }

    }
}