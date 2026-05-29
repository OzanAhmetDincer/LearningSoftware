using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class FindMaxAndMinNumberAlgorithm : IAlgorithm
    {
        public string Name => "En büyük/küçük sayıyı bulma";

        public string Description => "Girilen sayılardan en büyük/küçük olanını bulma";

        public void Execute()
        {
            int max = 0, min = 0, number = 0;
            Console.WriteLine("5 adet sayı giriniz: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. sayıyı giriniz: ");
                number = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    max = number;
                    min = number;
                }
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
            }

            Console.WriteLine("En büyük sayi:" + max);
            Console.WriteLine("En küçük sayi:" + min);
        }
    }
}
