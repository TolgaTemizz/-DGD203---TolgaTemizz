using System;

public class Engine
{
    public bool IsRunning { get; private set; }
    public int Horsepower { get; }

    public Engine(int horsepower)
    {
        Horsepower = horsepower;
        IsRunning = false;
    }

    public void Start()
    {
        if (!IsRunning)
        {
            IsRunning = true;
            Console.WriteLine("Engine started.");
        }
        else
        {
            Console.WriteLine("Engine is already running.");
        }
    }

    public void Stop()
    {
        if (IsRunning)
        {
            IsRunning = false;
            Console.WriteLine("Engine stopped.");
        }
        else
        {
            Console.WriteLine("Engine is not running.");
        }
    }
}