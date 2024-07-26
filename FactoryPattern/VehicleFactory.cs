namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(string tires)
    {
        switch (tires.ToLower())
        {
            case "4":
                Console.WriteLine("Car will have four wheels!");
                return new Car();
            case "2":
                Console.WriteLine("Motorcycle will have two wheels!");
                return new Motorcycle();
            default:
                return new Car();
              
        }
        
    }
}