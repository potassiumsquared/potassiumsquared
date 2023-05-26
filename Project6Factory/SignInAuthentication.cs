using System;

public class SignInAuthentication : IAuthentication
{
    public void Authenticate()
    {

        Console.WriteLine("Sign in with email and password.");
    }
}