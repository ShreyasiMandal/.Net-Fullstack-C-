// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    // Check if character is vowel
    static bool IsVowel(char ch)
    {
        ch = char.ToLower(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }

    public static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        // Store consonants from second word
        HashSet<char> consonants = new HashSet<char>();

        foreach (char ch in word2)
        {
            char c = char.ToLower(ch);
            if (!IsVowel(c))
                consonants.Add(c);
        }

        // Task 1==> Remove common consonants
        StringBuilder temp = new StringBuilder();

        foreach (char ch in word1)
        {
            char c = char.ToLower(ch);

            if (IsVowel(c) || !consonants.Contains(c))
                temp.Append(ch);
        }

        // Task 2==> Remove consecutive duplicates
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < temp.Length; i++)
        {
            if (i == 0 || temp[i] != temp[i - 1])
                result.Append(temp[i]);
        }

        Console.WriteLine(result.ToString());
    }
}
