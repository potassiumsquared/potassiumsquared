class Player
{
    public string Name;

    public int Level = 0;

    public bool JoinedGame = false;

    public Player(PlayerBuilder builder)
    {
        Name = builder.Name;
        Level = builder.Level;
        JoinedGame = builder.JoinedGame;

    }
    public string CreatePlayerDescription()
    {
        string description = "Your player name is: " + Name + ". Your level is: " + Level + ". Have you joined game: " + JoinedGame;
        return description;
    }
}