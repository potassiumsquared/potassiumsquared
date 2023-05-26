using System;

class CreditCardPayment : IMoney
{
    public void Buy(double purchasePrice)
    {
        Console.WriteLine("Purchase price: $" + purchasePrice);

    }
}