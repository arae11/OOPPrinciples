using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer : Person
{
    private string _deliveryAddress;
    public Customer(string FName, string LName, string DAddress) : base(FName, LName)
    {
        _deliveryAddress = DAddress;
    }

    public string DeliveryAddress { get => _deliveryAddress; set => _deliveryAddress = value; }

    public override void Print()
    {
        Console.Write($"Delivery Address: {_deliveryAddress}, ");
        base.Print();
    }
}

