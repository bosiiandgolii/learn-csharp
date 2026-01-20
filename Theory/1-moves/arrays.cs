using System;

class Program
{
    static void Main()
    {
        //arrays types of data
        // int - numbers without decimal point
        int[] numbers = new int[5]; //declaration of an array of integers with a size of 5
        numbers[0] = 10; //assigning values to the array elements
        numbers[1] = 20;

        // string - text data
        string[] words = new string[3]; //declaration of an array of strings with
        words[0] = "hello"; //assigning values to the array elements

        // double - numbers with decimal point
        double[] decimals = new double[4]; //declaration of an array of doubles with
        decimals[0] = 10.5; //assigning values to the array elements

        // Output the values to the console
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = "word" + (i + 1);
        }

        foreach (string word in words)
        {
            System.Console.WriteLine("String array element: " + word);
        }

        //multi-dimensional arrays
        int[,] matrix = new int[2, 3]; //declaration of a
        matrix[0, 0] = 1; //assigning values to the array elements
        matrix[0, 1] = 2;

        // Output the values of the multi-dimensional array
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.WriteLine("Matrix element at (" + i + "," + j + "): " + matrix[i, j]);
            }
        }

}
}