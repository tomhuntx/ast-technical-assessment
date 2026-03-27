namespace CodingChallenges;

/*
 * Question 3:
 * Write a function that checks if two strings are anagrams.
 */

public static class AnagramChecker
{
    public static bool AreAnagrams(string word1, string word2)
    {
        // False if any words are missing or if words aren't the same length
        // This would be replaced by error handling for better UX
        if (word1 == null || word2 == null || word1.Length != word2.Length)
            return false;

        // Sort words alphabetically
        var sorted1 = word1.ToLower().OrderBy(c => c);
        var sorted2 = word2.ToLower().OrderBy(c => c);

        // Compare words directly using LINQ
        return sorted1.SequenceEqual(sorted2);
    }
}