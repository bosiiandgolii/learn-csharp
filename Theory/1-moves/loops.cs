using System;

class Program
{
    static void Main()
    {
        
        // while loop
        int count = 0;
        while (count < 5)
        {
            System.Console.WriteLine("Count is: " + count);
            count++;
        }

        // do-while loop
        // This loop will execute at least once
        int number = 0;
        do
        {
            System.Console.WriteLine("Number is: " + number);
            number++;
        } while (number < 5);

        // for loop
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("i is: " + i);
        }

        // foreach loop
        // Iterating over an array
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            System.Console.WriteLine("Number from array: " + num);
        }

        // nested loops
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                System.Console.WriteLine("i: " + i + ", j: " + j);
            }
        }

        // break and continue
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                System.Console.WriteLine("Breaking at i = " + i);
                break; // exit the loop when i is 5
            }
            if (i % 2 == 0)
            {
                continue; // skip even numbers
            }
            System.Console.WriteLine("Odd i: " + i);
        }


    }
}