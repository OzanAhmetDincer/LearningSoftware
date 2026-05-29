using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class ReverseStringAlgorithm : IAlgorithm
    {
        public string Name => "Kelimeyi Tersten Yazma";
        public string Description => "Reverses a given string input.";

        public void Execute()
        {
            // Hazır fonksiyon kullanarak yapılan çözüm
            /*Console.Write("Input: ");
            var input = Console.ReadLine();

            var result = new string(input.Reverse().ToArray());

            Console.WriteLine($"Result: {result}");*/

            Console.Write("Bir kelime veya cümle girin: ");
            string text = Console.ReadLine();

            char[] reversedChars = new char[text.Length];

            int index = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedChars[index] = text[i];
                index++;
            }
            var result = new string(reversedChars);
            Console.WriteLine($"Ters hali: {result}");
        }
    }
}
