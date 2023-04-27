using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input_number = -1;

        while (input_number != 0){
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            Console.Write("Enter number:");
            string number_text = Console.ReadLine();
            input_number = int.Parse(number_text);

            if (input_number != 0)
            {
                numbers.Add(input_number);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

    
        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}");

        int largest = 0;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is {largest}.");
    }
}