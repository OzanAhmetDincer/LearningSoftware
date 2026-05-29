using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Application.Engine
{
    public class AlgorithmEngine
    {
        private readonly List<IAlgorithm> _algorithms;

        public AlgorithmEngine(List<IAlgorithm> algorithms)
        {
            _algorithms = algorithms;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n===== ALGORITHM RUNNER =====\n");

                for (int i = 0; i < _algorithms.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_algorithms[i].Name}");
                    Console.WriteLine($"   {_algorithms[i].Description}");
                }

                Console.WriteLine("0. Exit");
                Console.Write("\nSelect: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (choice == 0)
                    break;

                if (choice < 1 || choice > _algorithms.Count)
                {
                    Console.WriteLine("Invalid selection!");
                    continue;
                }

                Console.WriteLine("\n--- OUTPUT ---\n");
                _algorithms[choice - 1].Execute();
                Console.WriteLine("\n---------------\n");
            }
        }
    }
}
