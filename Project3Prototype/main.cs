using System;

class Program
{
    public static void Main(string[] args)
    {
        StoreBranch newYorkBranch = new StoreBranch("New York City");

        Console.WriteLine(newYorkBranch.Location);

        StoreBranch losAngelesBranch = newYorkBranch.Clone();

        losAngelesBranch.Location = "Los Angeles";

        Console.WriteLine(losAngelesBranch.Location);


    }
}