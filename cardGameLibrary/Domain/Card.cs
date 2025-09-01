namespace Domain.Cards;

    public enum Suit{
        Red = 1,
        Blue = 2,
        Green = 3,
        Yellow = 4, 
    }

public class Card
{
    // attributes
    public Suit Suit { get; } // read-only properties
    public int Number { get; }

    public Card(Suit suit, int number) // constructor 
    {
        Suit = suit;
        Number = number;

        if (number < 1 || number > 8) // validering af at nummer er mellem 1 og 8

        {
            throw new ArgumentOutOfRangeException(nameof(number), "number skal vare mellem 1 ... 8");
        }
    }

    public int GetValue()
    {
        return (int)Suit * Number;
    }



    // override = 
    public override string ToString() // tostring() = standard metode for klassen "objekt"
    {
        return $"hvilken farve: {Suit}, hvilket kort: {Number}, værdi = ({GetValue()})";
    }

}