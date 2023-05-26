using System;

class Program
{
    public static void Main(string[] args)
    {
        Person person0 = Person.Instance;
        Person person1 = Person.Instance;

        Console.WriteLine(person0);
        Console.WriteLine(person1);

        if (person0 == person1)
        {
            Console.WriteLine("Equal");
        }
    }
}