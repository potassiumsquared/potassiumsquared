public class Person
{

    static Person instance;

    public static Person Instance
    {
        get
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                instance = new Person();
                return instance;
            }
        }
    }
}