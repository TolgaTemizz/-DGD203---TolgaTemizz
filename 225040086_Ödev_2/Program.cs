class Program
{
    static void Main(string[] args)
    {
        // Create parts
        Engine engine = new Engine(150);
        List<Wheel> wheels = new List<Wheel>
        {
            new Wheel("Summer", 17, 32),
            new Wheel("Summer", 17, 32),
            new Wheel("Summer", 17, 32),
            new Wheel("Summer", 17, 32)
        };
        List<Seat> seats = new List<Seat>
        {
            new Seat(),
            new Seat(),
            new Seat(),
            new Seat()
        };
        FuelTank fuelTank = new FuelTank(50);
        Transmission transmission = new Transmission("Automatic");
        AirConditioner airConditioner = new AirConditioner();

        // Create car
        Car car = new Car(engine, wheels, seats, fuelTank, transmission, airConditioner);

        // Main menu loop
        bool isRunning = true;
        while (isRunning)
        {
            // Menüyü gösterelim ve her seçimde benzin miktarını güncelleyelim
            Console.Clear();
            Console.WriteLine("--- Car Menu ---");
            Console.WriteLine($"Fuel Level: {car.FuelTank.CurrentFuel}L");  // Benzin miktarı
            Console.WriteLine("1. Start Engine");
            Console.WriteLine("2. Stop Engine");
            Console.WriteLine("3. Shift Gear Up");
            Console.WriteLine("4. Shift Gear Down");
            Console.WriteLine("5. Drive");
            Console.WriteLine("6. Inflate Tire");
            Console.WriteLine("7. Check Dashboard");
            Console.WriteLine("8. Fasten Seatbelt");
            Console.WriteLine("9. Turn On Air Conditioner");
            Console.WriteLine("10. Turn Off Air Conditioner");
            Console.WriteLine("11. Set Air Conditioner Temperature");
            Console.WriteLine("12. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    car.Engine.Start();
                    break;

                case "2":
                    car.Engine.Stop();
                    break;

                case "3":
                    car.Transmission.ShiftUp();
                    break;

                case "4":
                    car.Transmission.ShiftDown();
                    break;

                case "5":
                    car.Drive();
                    break;

                case "6":
                    Console.Write("Enter tire number (1-4): ");
                    int tireNumber = int.Parse(Console.ReadLine()) - 1;
                    if (tireNumber >= 0 && tireNumber < car.Wheels.Count)
                    {
                        Console.Write("Enter inflation amount (PSI): ");
                        int psi = int.Parse(Console.ReadLine());
                        car.Wheels[tireNumber].Inflate(psi);
                    }
                    else
                    {
                        Console.WriteLine("Invalid tire number!");
                    }
                    break;

                case "7":
                    car.Dashboard();
                    break;

                case "8":
                    Console.Write("Enter seat number (1-4): ");
                    int seatNumber = int.Parse(Console.ReadLine()) - 1;
                    if (seatNumber >= 0 && seatNumber < car.Seats.Count)
                    {
                        car.Seats[seatNumber].IsOccupied = true;
                        car.Seats[seatNumber].FastenSeatbelt();
                    }
                    else
                    {
                        Console.WriteLine("Invalid seat number!");
                    }
                    break;

                case "9":
                    car.AirConditioner.TurnOn();
                    break;

                case "10":
                    car.AirConditioner.TurnOff();
                    break;

                case "11":
                    Console.Write("Enter desired temperature (°C): ");
                    int temperature = int.Parse(Console.ReadLine());
                    car.AirConditioner.SetTemperature(temperature);
                    break;

                case "12":
                    isRunning = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            // Menü sonrası bir tuşa basmak için bekle
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
