using AlgorithmRunner.Domain.Abstractions;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class IsPalindromeWordAlgorith : IAlgorithm
    {
        public string Name => "Palindrome Kelime mi?";

        public string Description => "Bir kelimenin palindrome olup olmadığını kontrol et";

        public void Execute()
        {
            Console.Write("Bir kelime giriniz: ");
            string word = Console.ReadLine();

            bool result = IsPalindrome(word);

            if (result)
            {
                Console.WriteLine("Palindrome kelime");
            }
            else
            {
                Console.WriteLine("Palindrome kelime değil");
            }
        }

        static bool IsPalindrome(string text)
        {
            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                if (text[left] != text[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
