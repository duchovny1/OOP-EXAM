namespace Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Pesho", "Whiskas");
            Dog dog = new Dog("Gosho", "Meat");

            System.Console.WriteLine(cat.ExplainSelf());
            System.Console.WriteLine(dog.ExplainSelf());

        }
    }
}
