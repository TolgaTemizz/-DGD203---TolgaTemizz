public class Car
{
    public Engine Engine { get; }
    public List<Wheel> Wheels { get; }
    public List<Seat> Seats { get; }
    public FuelTank FuelTank { get; }
    public Transmission Transmission { get; }
    public AirConditioner AirConditioner { get; } // Yeni eklenen özellik

    public Car(Engine engine, List<Wheel> wheels, List<Seat> seats, FuelTank fuelTank, Transmission transmission, AirConditioner airConditioner)
    {
        Engine = engine;
        Wheels = wheels;
        Seats = seats;
        FuelTank = fuelTank;
        Transmission = transmission;
        AirConditioner = airConditioner;
    }

    public void Drive()
    {
        if (Engine.IsRunning && FuelTank.CurrentFuel > 0 && Transmission.CurrentGear > 0)
        {
            FuelTank.Consume(5); // Consume 5L of fuel per drive
            Console.WriteLine("The car is driving!");
        }
        else
        {
            Console.WriteLine("Cannot drive. Check engine, fuel level, or gear.");
        }
    }

    public void Dashboard()
    {
        Console.WriteLine($"Engine status: {(Engine.IsRunning ? "Running" : "Stopped")}");
        Console.WriteLine($"Fuel level: {FuelTank.CurrentFuel}L");
        Console.WriteLine($"Current gear: {Transmission.CurrentGear}");
        Console.WriteLine($"Tire pressures: {string.Join(", ", Wheels.ConvertAll(w => w.Pressure))} PSI");
        Console.WriteLine($"Air conditioner: {(AirConditioner.IsOn ? $"On, Temperature: {AirConditioner.Temperature}°C" : "Off")}");
    }
}