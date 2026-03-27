using CodingChallenges;

// Question 1

Console.WriteLine("Question 1: Write a function that finds the largest and smallest numbers in an array");

int[] numbers = [5, 2, 9, 1, 5, 6];
Console.WriteLine($"Given {string.Join(", ", numbers)}");
var (largest, smallest) = ArraySorting.GetLargestAndSmallest(numbers);
Console.WriteLine($"Largest in array: = {largest}, Smallest in array = {smallest}");


// Question 2

Console.WriteLine("\n\n\n");
Console.WriteLine("Question 2: Write a function that removes duplicate characters from a string");

string input = "itt_iwoorkosksi!";

Console.WriteLine($"Input: {input}");

Console.WriteLine($"LINQ: {RemoveDuplicates.Simple(input)}");
Console.WriteLine($"HashSet: {RemoveDuplicates.Classic(input)}");
Console.WriteLine($"Nested Loops: {RemoveDuplicates.HashSet(input)}");
