using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class DigitOfNumberAlgorithm : IAlgorithm
    {
        public string Name => "Basamak Sayısını Bulma";

        public string Description => "Determining the number of digits and the digits of the entered number";

        public void Execute()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // Sayının kaç basamaklı olduğunu hesaplayalım
            int basamakSayisi = SayininBasamakSayisi(sayi);
            Console.WriteLine($"Girilen sayı {basamakSayisi} basamaklıdır.");

            // Sayının her bir basamağını ekrana yazdıralım
            Console.WriteLine("Basamaklar:");
            int temp = sayi;
            for (int i = 0; i < basamakSayisi; i++)
            {
                int basamak = temp % 10;
                Console.WriteLine($"{basamakSayisi - i}. basamak: {basamak}");
                temp /= 10;
            }
        }

        // Sayının kaç basamaklı olduğunu hesaplayan metot
        static int SayininBasamakSayisi(int sayi)
        {
            // Negatif sayı kontrolü
            if (sayi < 0)
            {
                sayi *= -1;
            }

            if (sayi == 0)
                return 1;

            int count = 0;
            while (sayi != 0)
            {
                count++;
                sayi /= 10;
            }
            return count;
        }
    }
}
