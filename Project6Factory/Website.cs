using System;

public class Website : Software
{
    protected override IAuthentication BuildAuthorization()
    {
        SignInAuthentication signIn = new SignInAuthentication();

        return signIn;
    }
}