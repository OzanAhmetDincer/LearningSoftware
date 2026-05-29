using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class FindEvenNumbersAlgorithm : IAlgorithm
    {
        public string Name => "Dizideki Çift Sayıları Bul";

        public string Description => "Bir dizideki çift sayıları listele";

        public void Execute()
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Çift sayılar: ");
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
