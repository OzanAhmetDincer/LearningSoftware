using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class MostRecurringCharacterAlgorithm : IAlgorithm
    {
        public string Name => "En Çok Tekrar Eden Karakter";

        public string Description => "En Çok Tekrar Eden Karakteri Bulma";

        public void Execute()
        {
            Console.Write("Bir kelime girin: ");
            string word = Console.ReadLine().ToLower();

            FindMostRepeatedLetter(word);
        }

        static void FindMostRepeatedLetter(string word)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            // Harfleri say
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                // Boşluk karakterini geç
                if (letter == ' ')
                    continue;

                if (letterCounts.ContainsKey(letter))
                {
                    letterCounts[letter]++;
                }
                else
                {
                    letterCounts.Add(letter, 1);
                }
            }

            Console.WriteLine("\nHarf Tekrar Sayıları:\n");

            foreach (KeyValuePair<char, int> item in letterCounts)
            {
                Console.WriteLine($"{item.Key} => {item.Value} kez");
            }

            // Tüm harf sayıları eşit mi kontrol et
            bool hepsiEsit = letterCounts.Values.All(x => x == letterCounts.Values.First());

            if (hepsiEsit)
            {
                Console.WriteLine("\nTüm harf sayıları eşittir.");
            }
            else
            {
                int maxCount = letterCounts.Values.Max();

                Console.WriteLine("\nEn Çok Tekrar Eden Harf(ler):");

                foreach (var item in letterCounts)
                {
                    if (item.Value == maxCount)
                    {
                        Console.WriteLine($"{item.Key} => {item.Value} kez");
                    }
                }
            }
        }
    }
}
