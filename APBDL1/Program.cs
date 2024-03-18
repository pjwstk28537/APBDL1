// See https://aka.ms/new-console-template for more information

public class Program
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The input array must not be null/empty.");
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            notSum += num;
        }

        double average = (double)sum / numbers.Length;
        return average;
    }
    
    public static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The input array must not be null/empty.");
        }
        int max = numbers[0]; 

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    
}

