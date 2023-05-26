class PlayerBuilder
{

    public string Name;
    public int Level;
    public bool JoinedGame;

    public PlayerBuilder()
    {
        Name = "Archer";
        Level = 1;
        JoinedGame = false;
    }

    public void JoinGame()
    {
        JoinedGame = true;
    }
    public Player BuildPlayer()
    {
        return new Player(this);
    }

}