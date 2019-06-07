using System;

namespace SimpleInjectorDemo
{
    public class PurchaseOrder : IOrder
    {
        public void process()
        {
            Console.WriteLine("Purchase Order Processed");
        }
    }
}
