namespace Restaurant.Food
{
    public class Cake : Dessert
    {
        private const double GramsPersDish = 250;
        private const double CaloriesPerDish = 1000;
        private const decimal CakePrice = 5;

        public Cake(string name) : base(name, CakePrice, GramsPersDish, CaloriesPerDish)
        {

        }

        
    }
}
