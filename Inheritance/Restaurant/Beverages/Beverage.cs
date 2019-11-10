namespace Restaurant.Beverages
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliters) : base(name, price)
        {
            this.Milliliters = milliters; // it might need one ctor more.
        }

        

        public double Milliliters { get; set; }
    }
}
