using Domain.GameClass;

Console.WriteLine("\nWelcome to the Card Game!\n ***** Rules are as followed *****\n\n 1. add players to play\n 2. when players are added. start game and random amount of cards are given\n 3. winner is the one with the most value in cards!");

Console.WriteLine("\n*** Choose one of the following by writing the number*** ");
Console.WriteLine("1. Start Game. \n2. Add players \n3. Show players. \n");

string numberChosen = "";
numberChosen = Console.ReadLine();

switch (numberChosen)
{
    case "1":
        Console.WriteLine("one was chosen");
        break;

    case "2":

        break;
    case "3":

        break;
}