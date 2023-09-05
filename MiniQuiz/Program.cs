class Program
{
    static void Main()
    {
        int count = 0;
        string[] suallar = {
            "Azerbaycanin bayraginda nece reng var ?",
            "Azerbaycanin paytaxti haradir ?",
            "Step It Academy necenci ilde yaranib ?",
            "2 + 2 = ?",
            "Bu gun necenci aydir ?",
            "Bir ilde nece fesil var ?",
            "Bir ilde nece ay var ?",
            "Hansi Reference typedir ?",
            "OOP project-i ne idi ?",
            "Bir gunde nece saat var ?"
        };

        string[][] variantlar = {
            new string[] { "a) 3", "b) 2", "c) 1" },
            new string[] { "a) Zengilan", "b) Baki", "c) Naxcivan" },
            new string[] { "a) 1998", "b) 2000", "c) 1999" },
            new string[] { "a) 2", "b) 4", "c) 5" },
            new string[] { "a) 9", "b) 10", "c) 11" },
            new string[] { "a) 2", "b) 3", "c) 4" },
            new string[] { "a) 12", "b) 11", "c) 10" },
            new string[] { "a) int", "b) float", "c) array" },
            new string[] { "a) BattleShip", "b) Quiz", "c) Millionier" },
            new string[] { "a) 24", "b) 12", "c) 8" }
        };

        string[] correctAnswers = { "a", "b", "c", "b", "a", "c", "a", "c", "b", "a" };

        Random rand = new Random();

        for (int i = 0; i < suallar.Length; i++)
        {
            Console.Clear();
            Console.WriteLine(suallar[i]);
            random(variantlar[i], rand);
            foreach (string item in variantlar[i])
                Console.WriteLine($"{item}");

            Console.Write("Cavabi daxil edin: ");
            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == correctAnswers[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Duzdur!");
                count += 10;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sehvdir! Duzgun cavab: " + correctAnswers[i]);
                count -= 10;
            }
            Console.ReadKey();
            Console.ResetColor();
        }

        if (count < 0)
            Console.WriteLine($"Umumi xal: 0");
        else
            Console.WriteLine($"Umumi xal: {count}");
    }

    static void random(string[] array, Random rand)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            int randomIndex = rand.Next(n);
            string temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }
}