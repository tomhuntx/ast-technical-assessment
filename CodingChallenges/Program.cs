using CodingChallenges;

// Question 1

Console.WriteLine("Question 1: Write a function that finds the largest and smallest numbers in an array");

int[] numbers = [5, 2, 9, 1, 5, 6];
Console.WriteLine($"Given {string.Join(", ", numbers)}");
var (largest, smallest) = ArraySorting.GetLargestAndSmallest(numbers);
Console.WriteLine($"Largest in array: = {largest}, Smallest in array = {smallest}");

// Question 2

Console.WriteLine("\n\n\nQuestion 2: Write a function that removes duplicate characters from a string");

string input = "itt iwoor kosk si!!!";

Console.WriteLine($"Input: {input}");

Console.WriteLine($"LINQ: {RemoveDuplicates.Simple(input)}");
Console.WriteLine($"HashSet: {RemoveDuplicates.Classic(input)}");
Console.WriteLine($"Nested Loops: {RemoveDuplicates.HashSet(input)}");

// Question 3

Console.WriteLine("\n\n\nQuestion 3: Write a function that checks if two strings are anagrams");

// Helper method
static string GetAnagramResult(string word1, string word2)
{
    bool result = AnagramChecker.AreAnagrams(word1, word2);
    return $"Are \"{word1}\" and \"{word2}\" anagrams? {(result ? "Yes" : "No")}";
}

Console.WriteLine(GetAnagramResult("elbow", "below"));
Console.WriteLine(GetAnagramResult("elbow", "echidna"));
Console.WriteLine(GetAnagramResult("Vile", "Evil"));

// Question 4

Console.WriteLine("\n\n\nQuestion 4: Write a RegEx to match an Australian mobile phone");

// Helper method
static string GetPhoneValidationResult(string number)
{
    bool isValid = PhoneValidator.IsValidMobile(number);
    return $"Is \"{number}\" a valid Australian mobile? {(isValid ? "Yes" : "No")}";
}

Console.WriteLine(GetPhoneValidationResult("0412 345 678"));
Console.WriteLine(GetPhoneValidationResult("+61412345678"));
Console.WriteLine(GetPhoneValidationResult("12345"));