using System;

class OnlinePayment
{

    public IMoney Money;
    public OnlinePayment(IMoney _Money)
    {
        Money = _Money;

    }
    public void MakeAPurchase(double purchasePrice)
    {
        Money.Buy(purchasePrice);
    }
}