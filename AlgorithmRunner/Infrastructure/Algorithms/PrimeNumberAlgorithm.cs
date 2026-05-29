using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class PrimeNumberAlgorithm : IAlgorithm
    {
        public string Name => "Prime Checker";
        public string Description => "Checks if a number is prime.";

        public void Execute()
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not prime");
                return;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
            }

            Console.WriteLine("Prime");
        }
    }
}
