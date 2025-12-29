using System;

class Program
{
    static void Main()
    {
        // Concatenating strings
        string firstWord = "Hello";
        string secondWord = "World";
        System.Console.WriteLine(firstWord + " " + secondWord);

        // Using variables in strings
        int age = 17;

        System.Console.WriteLine("age = " + age);

        // String interpolation
        System.Console.WriteLine($"age = {age}");

        // Escape sequences
        System.Console.WriteLine($"age today {age}\n age tomorrow {age + 1}");

        // Verbatim strings
        System.Console.WriteLine(@"1 string
        2 string
        3 string");
        
        System.Console.WriteLine(Console.ReadLine());
        
    }
}