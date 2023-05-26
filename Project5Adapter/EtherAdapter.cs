using System;

class EtherAdapter : IMammothBank
{

    EtherPayment OurEthPayment;

    public EtherAdapter(EtherPayment _OurEthPayment)
    {
        OurEthPayment = _OurEthPayment;
    }
    public void Pay(double amount)
    {
        OurEthPayment.TransactEther(amount);

    }
}