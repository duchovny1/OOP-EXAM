namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle(200, 10);
            motorcycle.Drive(10);
            System.Console.WriteLine(motorcycle.Fuel);
            System.Console.WriteLine(motorcycle.FuelConsumption);


            RaceMotorcycle racer = new RaceMotorcycle(200, 100);
            racer.Drive(10);
            System.Console.WriteLine(racer.Fuel);
            System.Console.WriteLine(racer.FuelConsumption);
            System.Console.WriteLine(motorcycle.FuelConsumption);
        }
    }
}
