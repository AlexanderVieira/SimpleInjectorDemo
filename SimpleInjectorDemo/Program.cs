namespace SimpleInjectorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new SimpleInjector.Container();
            container.Register<IOrder, PurchaseOrder>();

            var shoppinCart = container.GetInstance<ShoppingCart>();
            shoppinCart.CheckOut();
        }
    }
}
