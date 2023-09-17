using System;
using System.Text.RegularExpressions;

class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        // Remove spaces and punctuation, and convert to lowercase
        string cleanedInput = Regex.Replace(input, @"[\W_]", "").ToLower();

        int left = 0;
        int right = cleanedInput.Length - 1;

        while (left < right)
        {
            if (cleanedInput[left] != cleanedInput[right])
            {
                return false; // Characters do not match, not a palindrome
            }
            left++;
            right--;
        }

        return true; // All characters matched, it's a palindrome
    }

    public static void Main()
    {
        Console.WriteLine("Palindrome Checker");

        // Input string to check for palindrome
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("It's a palindrome!");
        }
        else
        {
            Console.WriteLine("It's not a palindrome.");
        }
    }
}
