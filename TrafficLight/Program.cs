using TrafficLight;

public class Program
{
    private static void Main(string[] args)
    {
        TrafficLightModel trafficLight = new TrafficLightModel();
        string checkEnter;

        do
        {
            Console.WriteLine(trafficLight.ShowColour());
            checkEnter = Console.ReadLine();

            if (string.IsNullOrEmpty(checkEnter))
            {
                trafficLight.NextState();
            }
        } while (string.IsNullOrEmpty(checkEnter));
    }
}