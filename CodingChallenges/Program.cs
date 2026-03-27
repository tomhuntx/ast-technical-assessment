
// Question 1: Write a function that finds the largest and smallest numbers in an array

using CodingChallenges;

int[] numbers = [5, 2, 9, 1, 5, 6];
Console.WriteLine($"Given {string.Join(", ", numbers)}");
var (largest, smallest) = ArraySorting.GetLargestAndSmallest(numbers);
Console.WriteLine($"Largest in array: = {largest}, Smallest in array = {smallest}");

