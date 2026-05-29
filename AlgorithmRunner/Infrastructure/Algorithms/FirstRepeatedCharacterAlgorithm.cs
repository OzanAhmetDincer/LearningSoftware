using AlgorithmRunner.Domain.Abstractions;
using static System.Net.Mime.MediaTypeNames;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class FirstRepeatedCharacterAlgorithm : IAlgorithm
    {
        public string Name => "İlk Tekrar Eden Karakter";

        public string Description => "Bir string içindeki ilk tekrar eden karakteri bul";

        public void Execute()
        {
            Console.Write("Bir kelime giriniz: ");
            string text = Console.ReadLine();

            char result = FindFirstRepeatedCharacter(text);

            Console.WriteLine($"İlk en çok tekrar eden harf: {result}");
        }

        static char FindFirstRepeatedCharacter(string text)
        {
            HashSet<char> seenCharacters = new HashSet<char>();

            foreach (char c in text)
            {
                if (seenCharacters.Contains(c))
                {
                    return c;
                }

                seenCharacters.Add(c);
            }

            return ' ';
        }
    }
}
