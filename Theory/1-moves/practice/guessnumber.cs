using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        int tryCount = 5;
        int number;
        int lower;
        int higher;
        int userInput;

        Random random = new Random();

        System.Console.Write("type lowest number  ");
        lower = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("type highest number  ");
        higher = Convert.ToInt32(System.Console.ReadLine());
        number = random.Next (lower, higher);

        System.Console.WriteLine("try to guess number by  " + tryCount + "  tryes");

        while (tryCount > 0)
        {
        userInput = Convert.ToInt32(System.Console.ReadLine());
        if (userInput == number)
            {
                System.Console.WriteLine("ura!!!");
                break;
            }
        else
            {
                tryCount--;
                System.Console.WriteLine("kys");
            }
        
        }
    }
}