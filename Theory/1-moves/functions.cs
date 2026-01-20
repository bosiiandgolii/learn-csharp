using System;

class Program
{
    static void Main()
    {
        //functions
        int a = 5;
        int b = 10;
        int result = Sum(a, b);
        System.Console.WriteLine("Sum: " + result);
    }

    static int Sum(int x, int y)
    {
        return x + y;
    }

    //integrated function
    static void PrintMessage(string message)
    {
        System.Console.WriteLine(message); //integrated function is WriteLine
    }
    
    //function modifiers: static, public, private, protected
    //static - belongs to the class, not to an instance
    //public - accessible from anywhere
    //private - accessible only within the class
    //protected - accessible within the class and its subclasses

    //void and return types
    static void VoidFunction()
    {
        System.Console.WriteLine("This function does not return a value.");
    }

    static int ReturnFunction()
    {
        return 42; //this function returns an integer value
    }

    //optional parameters
    static void OptionalParameters(int x, int y = 10)
    {
        System.Console.WriteLine("x: " + x + ", y: " + y);
    
    }

    
}