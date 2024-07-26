using System.Numerics;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires do you want for your vehicle?");
            string userVehicle = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.Drive();
        }
    }
}
