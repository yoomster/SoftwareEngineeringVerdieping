using CarProject;

public class Program
{
    private static void Main(string[] args)
    {
        CarModel Car = new CarModel();
        bool driving = true;

        Car.SetManufacturer("Tesla");
        Car.SetModel("Cross");

        do
        {
            Console.Clear();
            Console.WriteLine($"Auto info: {Car.GetInfo()}");
            Console.WriteLine();
            Console.WriteLine("Typ + om gas te geven.");
            Console.WriteLine("Typ - om te remmen.");
            Console.WriteLine("Typ s om te stoppen.");
            ConsoleKeyInfo carAction= Console.ReadKey();
            if (carAction.KeyChar.Equals('+'))
            {
                Car.SpeedUp();
            }
            else if (carAction.KeyChar.Equals('-'))
            {
                Car.SlowDown();
            }
            else if (carAction.KeyChar.Equals('s'))
            {
                driving = false;
            }
        }
        while (driving);

        Console.ReadLine();
    }
}