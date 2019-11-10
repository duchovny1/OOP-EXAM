namespace Restaurant.Food
{
    public class Fish : MainDish
    {
        private const double GramsPerDish = 22;

        public Fish(string name, decimal price) : base(name, price, GramsPerDish)
        {
        }

        
    }
}
