using Calculator;
using System.Threading.Channels;

public class Program
{
    private static void Main(string[] args)
    {
        CalculatorModel calculator = new CalculatorModel();
        bool calculating = true;
        do
        {
            Console.Clear();
            Console.Write($"Welkom bij het rekenmachine, vul aub het eerste nr in om mee te rekenen: ");
            string numberOne = Console.ReadLine();
            int.TryParse(numberOne, out int nrOne);
            calculator.SetNumberOne(nrOne);

            Console.Write($"Vul aub het tweede nr in om mee te rekenen: ");
            string numberTwo = Console.ReadLine();
            int.TryParse(numberTwo, out int nrTwo);
            calculator.SetNumberTwo(nrTwo);

            Console.WriteLine();
            Console.WriteLine($"Typ + om op te tellen.");
            Console.WriteLine($"Typ - om af te trekken.");
            Console.WriteLine($"Typ / om op te tellen.");
            Console.WriteLine($"Typ * om op te tellen.");
            Console.WriteLine("Typ s om te stoppen.");
            ConsoleKeyInfo calculateChoice = Console.ReadKey();
            Console.ReadLine();
            if (calculateChoice.KeyChar.Equals('+'))
            {
                Console.WriteLine(calculator.Add());
                Console.WriteLine();

            }
            else if (calculateChoice.KeyChar.Equals('-'))
            {
                Console.WriteLine(calculator.Subtract());
                Console.WriteLine();

            }
            else if (calculateChoice.KeyChar.Equals('/'))
            {
                Console.WriteLine(calculator.Divide());
                Console.WriteLine();

            }
            else if (calculateChoice.KeyChar.Equals('*'))
            {
                Console.WriteLine(calculator.Multiply());
                Console.WriteLine();

            }
            else if (calculateChoice.KeyChar.Equals('s'))
            {
                calculating = false;
            }
            Console.ReadLine();
        }
        while (calculating);
    }
}