using System;

public class Wheel
{
    public string Type { get; }
    public int Size { get; }
    public int Pressure { get; private set; }

    public Wheel(string type, int size, int pressure)
    {
        Type = type;
        Size = size;
        Pressure = pressure;
    }

    public void Inflate(int psi)
    {
        Pressure += psi;
        Console.WriteLine($"Tire inflated. New pressure: {Pressure} PSI.");
    }
}