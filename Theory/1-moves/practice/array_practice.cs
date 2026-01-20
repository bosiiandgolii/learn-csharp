using System;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, 4, 5};
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        System.Console.WriteLine("Sum of array elements: " + sum);
   }
}