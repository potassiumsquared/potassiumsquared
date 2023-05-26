public class StoreBranch
{
    public string Location { get; set; }
    public StoreBranch(string _Location)
    {
        Location = _Location;
    }
    public StoreBranch Clone()
    {
        return MemberwiseClone() as StoreBranch;
    }

}