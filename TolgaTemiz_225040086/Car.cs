using System;
using System.Collections.Generic;

public class Car
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
    public int EngineSize { get; set; }

    public Car(string model, string brand, string type, int engineSize)
    {
        Model = model;
        Brand = brand;
        Type = type;
        EngineSize = engineSize;
    }

    // Arabayla ilgili daha model odaklı ipuçları döndüren bir metot
    public List<string> GetHints()
    {
        return new List<string>
        {
            $"Bu araba {Brand} markasına ait.",
            $"Bu bir {Type} tipi araç.",
            $"Motor hacmi {EngineSize} litre.",
            $"Modelin ilk harfi: {Model[0]}."
        };
    }
}