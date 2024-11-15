using System;

public class FuelTank
{
    public int Capacity { get; }
    public int CurrentFuel { get; private set; }

    public FuelTank(int capacity)
    {
        Capacity = capacity;
        CurrentFuel = capacity; // Start with a full tank
    }

    public void Consume(int amount)
    {
        if (CurrentFuel >= amount)
        {
            CurrentFuel -= amount;
            Console.WriteLine($"Fuel consumed: {amount}L. Remaining fuel: {CurrentFuel}L.");
        }
        else
        {
            Console.WriteLine("Not enough fuel!");
        }
    }
}