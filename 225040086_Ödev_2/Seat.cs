using System;

public class Seat
{
    public bool IsOccupied { get; set; }
    public bool IsSeatbeltFastened { get; private set; }

    public void FastenSeatbelt()
    {
        if (IsOccupied)
        {
            IsSeatbeltFastened = true;
            Console.WriteLine("Seatbelt fastened.");
        }
        else
        {
            Console.WriteLine("Seat is unoccupied. Cannot fasten seatbelt.");
        }
    }
}