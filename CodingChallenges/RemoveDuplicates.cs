using System.Text;

namespace CodingChallenges;

/*
 * Question 2:
 * Write a function that removes duplicate characters from a string.
 * Provide at least 3 solutions (and describe which is the best in my opinion).
 * 
 * Note that this code is over-commented for this assessment.
 * 
 * 
 * MY ANSWER:
 * 
 * #1 - Using LINQ is my favourite approach.
 * It's simple, minimal, and just as fast as the HashSet.
 * LINQ is also a part of core .NET now so no third-party installs or imports needed.
 * 
 * It could even be written in one line as:
 * return new string([.. input.Distinct()]);
 */

public static class RemoveDuplicates
{
    // Approach 1: LINQ
    public static string Simple(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // Using Distinct to filter out duplicate characters
        var distinct = input.Distinct().ToArray();

        // Distinct returns char[] so convert it back to a string
        return new string(distinct);
    }

    // Approach 2: Nested Loops
    // Note: Less efficient, over-engineered, but timeless
    public static string Classic(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var result = new StringBuilder();

        // Loop through entire input
        for (int i = 0; i < input.Length; i++)
        {
            bool duplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (input[i] == input[j])
                {
                    duplicate = true;
                    break;
                }
            }

            if (!duplicate)
                result.Append(input[i]);
        }

        return result.ToString();
    }

    // Approach 3: HashSet - ChatGPT's favourite
    // Note: HashSets are efficient and this is viable but it's too verbose
    public static string HashSet(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var seen = new HashSet<char>();
        var result = new StringBuilder();

        foreach (var c in input)
            if (seen.Add(c))
                result.Append(c);

        return result.ToString();
    }
}