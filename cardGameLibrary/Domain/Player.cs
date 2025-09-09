using Domain.CardClass;
namespace Domain.PlayerClass;

public class Player
{
    private readonly List<Cards> hand; // hand of player
    public Player() //Constructor
    {
        hand = new List<Cards>(); // initializing the hand as an empty list of cards


    }

    // method to show the player's hand
    public string ShowHand()
    {
        return string.Join(", ", hand);
    }

    // method to calculate total hand value
    public int TotalHandValue()
    {
        return 0;
    }

    // player can accept any card
    // virtual = can be overridden in derived classes
    public virtual void AcceptCard(Cards card)
    {
        hand.Add(card); // adding the card to the player's hand
    }
}

public class WeakPlayer : Player // inheritance from Player class
{
    public override void AcceptCard(Cards card) // overriding the AcceptCard method
    {
        if (card.GetValue() < 20)
        {
            base.AcceptCard(card); // calling the base class method
        }
    }
}


