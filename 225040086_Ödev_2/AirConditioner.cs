using System;

public class AirConditioner
{
    public bool IsOn { get; private set; }
    public int Temperature { get; private set; }

    public AirConditioner()
    {
        IsOn = false;
        Temperature = 22; // Default temperature in Celsius
    }

    public void TurnOn()
    {
        if (!IsOn)
        {
            IsOn = true;
            Console.WriteLine("Air conditioner turned on.");
        }
        else
        {
            Console.WriteLine("Air conditioner is already on.");
        }
    }

    public void TurnOff()
    {
        if (IsOn)
        {
            IsOn = false;
            Console.WriteLine("Air conditioner turned off.");
        }
        else
        {
            Console.WriteLine("Air conditioner is already off.");
        }
    }

    public void SetTemperature(int temperature)
    {
        if (IsOn)
        {
            Temperature = temperature;
            Console.WriteLine($"Temperature set to {Temperature}°C.");
        }
        else
        {
            Console.WriteLine("Air conditioner is off. Please turn it on first.");
        }
    }
}