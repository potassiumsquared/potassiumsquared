using System;

class Program
{
    public static void Main(string[] args)
    {
        CreditCardPayment cardPayment = new CreditCardPayment();

        cardPayment.Buy(1000.10);

        OnlinePayment onlinePayment = new OnlinePayment(cardPayment);

        onlinePayment.MakeAPurchase(2000.20);
    }
}