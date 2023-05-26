using System;

class Program
{
    public static void Main(string[] args)
    {

        PlayerBuilder playerBuilder = new PlayerBuilder();

        Player playerBuilt = playerBuilder.BuildPlayer();

        Console.WriteLine(playerBuilt.CreatePlayerDescription());

        playerBuilder.JoinGame();

        Player playerBuilt1 = playerBuilder.BuildPlayer();

        Console.WriteLine(playerBuilt1.CreatePlayerDescription());

    }
}