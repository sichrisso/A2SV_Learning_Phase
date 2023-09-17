using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class WordFrequencyCounter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Word Frequency Count");
        
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        string[] words = Regex.Split(input, @"\W+");
        
        foreach (string word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }
        }

        foreach (var feq in wordFrequency)
        {
            Console.WriteLine($"Word: {feq.Key}, Frequency: {feq.Value}");
        }
    }
}
