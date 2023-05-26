using System;

public abstract class Software
{
    abstract protected IAuthentication BuildAuthorization();

    public void AuthenticateSoftware()
    {
        IAuthentication anyAuthentication = BuildAuthorization();

        anyAuthentication.Authenticate();
    }
}