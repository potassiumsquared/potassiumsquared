using System;

class Store
{

    public void Transact(IMammothBank bank, double amount)
    {
        bank.Pay(amount);
    }
}