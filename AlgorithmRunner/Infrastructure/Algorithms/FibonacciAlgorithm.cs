using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class FibonacciAlgorithm : IAlgorithm
    {
        public string Name => "Fibonacci Sequence";
        public string Description => "Generates Fibonacci numbers.";

        public void Execute()
        {
            Console.Write("Count: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                (a, b) = (b, a + b);
            }

            Console.WriteLine();
        }
    }
}
