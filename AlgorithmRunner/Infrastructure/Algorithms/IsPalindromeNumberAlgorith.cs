using AlgorithmRunner.Domain.Abstractions;
using System;

namespace AlgorithmRunner.Infrastructure.Algorithms
{
    public class IsPalindromeNumberAlgorith : IAlgorithm
    {
        public string Name => "Palindrome Sayı mı?";

        public string Description => "Bir sayının palindrome olup olmadığını kontrol et";

        public void Execute()
        {
            Console.Write("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = 0;
            int originalNum = number;

            while (number > 0)
            {
                var remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            var boole = reversedNumber == originalNum;
            if (boole)
            {
                Console.Write("Palindrome sayıdır");
            }
            else
            {
                Console.Write("Palindrome sayıdır değil");
            }
        }
    }
}
