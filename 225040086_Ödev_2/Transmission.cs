using System;

public class Transmission
{
    public string Type { get; }
    public int CurrentGear { get; private set; }

    public Transmission(string type)
    {
        Type = type;
        CurrentGear = 0;
    }

    public void ShiftUp()
    {
        CurrentGear++;
        Console.WriteLine($"Shifted up to gear {CurrentGear}.");
    }

    public void ShiftDown()
    {
        if (CurrentGear > 0)
        {
            CurrentGear--;
            Console.WriteLine($"Shifted down to gear {CurrentGear}.");
        }
        else
        {
            Console.WriteLine("Already in neutral.");
        }
    }
}