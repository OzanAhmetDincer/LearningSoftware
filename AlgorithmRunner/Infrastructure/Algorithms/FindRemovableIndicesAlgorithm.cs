using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class FindRemovableIndicesAlgorithm : IAlgorithm
    {
        public string Name => "İki diziyi birbirine eşitleme";

        public string Description => "İki diziyi birbirine eşitlemek için 2. diziden çıkarılacak indexler";

        public void Execute()
        {
            string str1 = "abcc";
            string str2 = "abc";

            List<int> result = FindRemovableIndices(str1, str2);

            Console.WriteLine("Sonuç:");
            Console.WriteLine("str1 = abcc ve str2 = abc kelimelerini eşitlemek için çıkarılabilecek indexler");

            foreach (int index in result)
            {
                Console.WriteLine(index);
            }
        }

        static List<int> FindRemovableIndices(string str1, string str2)
        {
            List<int> indices = new List<int>();

            // Uzunluk kontrolü
            if (str1.Length != str2.Length + 1)
            {
                indices.Add(-1);
                return indices;
            }

            // Her karakteri sırayla silmeyi dene
            for (int removeIndex = 0; removeIndex < str1.Length; removeIndex++)
            {
                bool isMatch = true;

                int j = 0;

                for (int i = 0; i < str1.Length; i++)
                {
                    // Silinecek indexi atla
                    if (i == removeIndex)
                        continue;

                    if (str1[i] != str2[j])
                    {
                        isMatch = false;
                        break;
                    }

                    j++;
                }

                if (isMatch)
                {
                    indices.Add(removeIndex);
                }
            }

            // Hiç bulunamadıysa
            if (indices.Count == 0)
            {
                indices.Add(-1);
            }

            return indices;
        }
    }
}
