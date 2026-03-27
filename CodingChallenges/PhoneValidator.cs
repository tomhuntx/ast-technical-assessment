using System.Text.RegularExpressions;

namespace CodingChallenges;

/*
 * Question 3:
 * Write a function that checks if two strings are anagrams.\
 * 
 * Answer:
 * 04\d{8} or ^04\d{8}$
 * Starts with 04, followed by 8 digits
 * 
 * Could do below to include +61
 * ^(\+61|0)4\d{8}$
 * 
 * The example below is generated to maintain the console app convention
 */

public static class PhoneValidator
{
    // Matches Australian mobile number (with optional +61)
    private const string MobilePattern = @"^(?:\+61|0)4\d{8}$";

    // Compiled regex for better performance if reused often
    private static readonly Regex MobileRegex = new(MobilePattern, RegexOptions.Compiled);

    public static bool IsValidMobile(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        // Clean spaces
        _ = Regex.Replace(input, @"\s+", "");

        return MobileRegex.IsMatch(input);
    }
}