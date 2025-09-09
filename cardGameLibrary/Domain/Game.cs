using Domain.PlayerClass;
using Domain.DeckClass;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace Domain.GameClass;

public class Game
{
    Dictionary<string, Player> players;

    public Game() // constructor
    {
        players = new Dictionary<string, Player>();
    }

    public void Start()
    {

    }

    public void acceptPlayer(Player player)
    {
        string playerName ="";
        Console.WriteLine("Write name of player");
        playerName = Console.ReadLine();

        players.Add(playerName, player);
    }

    public string AnnounceWinner()
    {
        return "";
    }

    
}