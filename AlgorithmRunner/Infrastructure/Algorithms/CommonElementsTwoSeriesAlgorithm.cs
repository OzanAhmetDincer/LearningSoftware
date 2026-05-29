using AlgorithmRunner.Domain.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class CommonElementsTwoSeriesAlgorithm : IAlgorithm
    {
        public string Name => "İki Dizinin Ortak Elemanları";

        public string Description => "İki Dizinin Ortak Elemanları Bulma";

        public void Execute()
        {
            int[] firstArray = { 1, 2, 3, 4, 4, 4 };
            int[] secondArray = { 3, 4, 5, 6 };

            FindCommonElements(firstArray, secondArray);
        }
        
        static void FindCommonElements(int[] firstArray, int[] secondArray)
        {
            HashSet<int> numbers = new HashSet<int>(firstArray);

            Console.WriteLine("Ortak Elemanlar:");

            foreach (int number in secondArray)
            {
                if (numbers.Contains(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
