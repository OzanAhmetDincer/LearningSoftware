using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class FactorialUseRecursiveMethodAlgorithm : IAlgorithm
    {
        public string Name => "Recursive method kullanarak factorial hesapla";

        public string Description => "Recursive method kullanarak factorial hesapla";

        public void Execute()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            int result = Factorial(sayi);

            Console.WriteLine($"{sayi} sayısının faktoriyeli: {result}");
        }

        static int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
