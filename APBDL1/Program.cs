// See https://aka.ms/new-console-template for more information

public class Program
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The input array must not be null or empty.");
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Length;
        return average;
    }
    
    public static void Main(string[] args)
    {
        // Example usage:
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"The average is: {average}");
    }
}

