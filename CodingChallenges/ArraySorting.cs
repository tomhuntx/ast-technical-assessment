namespace CodingChallenges;

/*
 * Question 1:
 * Write a function that finds the largest and smallest numbers in an array.
 */

public static class ArraySorting
{
    public static (int largest, int smallest) GetLargestAndSmallest(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array cannot be null or empty");

        int largest = numbers[0];
        int smallest = numbers[0];

        // Loop through numbers and compare to find largest and smallest
        foreach (var num in numbers)
        {
            if (num < smallest)
                smallest = num;

            if (num > smallest)
                largest = num;
        }

        return (largest, smallest);
    }
}