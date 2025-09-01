using Domain.Cards;

namespace Domain.Decks
{

    public class Deck
    {
        private readonly List<Card> deck;

        public Deck(List<Card> Deck) // constructor
        {
            Deck = deck;

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
            var range = new Random(); // system.random 
            var randomCard = List[range.Next(List.Count)];

        }


        public void DealtTo()
        {

        }

    }
}