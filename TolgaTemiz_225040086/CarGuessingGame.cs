using System;
using System.Collections.Generic;

public class CarGuessingGame
{
    private List<Car> Cars;
    private Car SelectedCar;
    private int MaxAttempts = 5;

    public CarGuessingGame()
    {
        Cars = new List<Car>
        {
            new Car("Civic", "Honda", "Sedan", 1),
            new Car("Mustang", "Ford", "Spor", 5),
            new Car("Camry", "Toyota", "Sedan", 2),
            new Car("Model S", "Tesla", "Elektrikli", 0),
            new Car("A4", "Audi", "Sedan", 2),
            new Car("Corolla", "Toyota", "Sedan", 1),
            new Car("F-150", "Ford", "Kamyonet", 3),
            new Car("X5", "BMW", "SUV", 3),
            new Car("S-Class", "Mercedes", "Lüks", 4),
            new Car("Impala", "Chevrolet", "Sedan", 2),
            new Car("Wrangler", "Jeep", "SUV", 2),
            new Car("911", "Porsche", "Spor", 4),
            new Car("Leaf", "Nissan", "Elektrikli", 0),
            new Car("Yaris", "Toyota", "Hatchback", 1),
            new Car("Tiguan", "Volkswagen", "SUV", 2),
            new Car("A3", "Audi", "Hatchback", 1),
            new Car("Altima", "Nissan", "Sedan", 2),
            new Car("Fusion", "Ford", "Sedan", 2),
            new Car("Cayenne", "Porsche", "SUV", 3),
            new Car("Rogue", "Nissan", "SUV", 2),
            new Car("Taurus", "Ford", "Sedan", 2),
            new Car("Cherokee", "Jeep", "SUV", 3),
            new Car("300", "Chrysler", "Sedan", 3),
            new Car("Q5", "Audi", "SUV", 2),
            new Car("Kona", "Hyundai", "SUV", 1),
            new Car("M3", "BMW", "Spor", 3),
            new Car("Camaro", "Chevrolet", "Spor", 4),
            new Car("Jetta", "Volkswagen", "Sedan", 1),
            new Car("F-Type", "Jaguar", "Spor", 5)
        };
    }

    public void StartGame()
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Rastgele bir araba seç
            Random random = new Random();
            SelectedCar = Cars[random.Next(Cars.Count)];

            Console.WriteLine("Araba tahmin oyununa hoş geldiniz!");
            var hints = SelectedCar.GetHints();
            bool correctGuess = false;

            // MaxAttempts yerine ipuçları sayısına kadar döngü
            for (int i = 0; i < hints.Count; i++) // hints.Count ile döngü uzunluğunu kontrol ediyoruz
            {
                Console.WriteLine($"İpucu {i + 1}: {hints[i]}");
                Console.Write("Tahmininiz nedir? ");
                string guess = Console.ReadLine();

                if (guess.Equals(SelectedCar.Model, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Tebrikler, doğru tahmin!");
                    correctGuess = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Tekrar deneyin.");
                }
            }

            if (!correctGuess)
            {
                Console.WriteLine($"Üzgünüz, bilemediniz. Doğru cevap: {SelectedCar.Model}");
            }

            // Oyunu bitirdikten sonra tekrar oynamak isteyip istemediğini sor
            Console.Write("Yeniden oynamak ister misiniz? (Evet/Hayır): ");
            string response = Console.ReadLine().Trim().ToLower();

            if (response != "evet")
            {
                playAgain = false;
                Console.WriteLine("Oyun bitti. Teşekkürler!");
            }
        }
    }
}