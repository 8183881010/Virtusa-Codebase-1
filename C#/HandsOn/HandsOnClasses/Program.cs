namespace HandsOnClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate customer
            Customer c1 = new Customer();
            c1.customerId = 342342;
            c1.customerName = "Neel";
            c1.city = "Chennai";
            c1.Details();
        }
    }
}