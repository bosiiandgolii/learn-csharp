using System;

class Program
{
    static void Main()
    {
       //conditional statements
        age = 18;

        //if
        if (age < 18)
        {
            System.Console.WriteLine("svobodnii");
        } 

        //if-else
        if (age < 18)
        {
            System.Console.WriteLine("svobodnii");
        } 
        else
        {
            System.Console.WriteLine("ne svobodnii");
        }

        //if-else if-else
        if (age < 18)
        {
            System.Console.WriteLine("svobodnii");
        } 
        else if (age == 18)
        {
            System.Console.WriteLine("pochti svobodnii");
        }
        else
        {
            System.Console.WriteLine("ne svobodnii");
        }

        //switch
        switch (age)
        {
            case 16:
                System.Console.WriteLine("svobodnii");
                break;
            case 18:
                System.Console.WriteLine("pochti svobodnii");
                break;
            default:
                System.Console.WriteLine("ne svobodnii");
                break;
        }

        //switch with relational patterns
        switch (age)
        {
            case < 18:
            case 18:
                System.Console.WriteLine("svobodnii");
                break;
            default:
                System.Console.WriteLine("ne svobodnii");
                break;
        }

        //ternary operator
        string result = (age < 18) ? "svobodnii" : "ne svobodnii";

        //combimed conditions
        if (age > 18 && age < 60)
        {
            System.Console.WriteLine("rabotaiushii");
        }

        if (age < 18 || age > 60)
        {
            System.Console.WriteLine("nesovetuiushii");
        }
        
    }
}