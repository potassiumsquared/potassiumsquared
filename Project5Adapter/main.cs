using System;

class Program
{
    public static void Main(string[] args)
    {
        EtherPayment etherPayment = new EtherPayment();

        etherPayment.TransactEther(150.25);

        EtherAdapter etherAdapter = new
    EtherAdapter(etherPayment);

        etherAdapter.Pay(200.55);


        Store store = new Store();

        store.Transact(etherAdapter, 300.33);
    }
}