using System;

class Program
{
    static void Main()
    {
        //main 
        int age = 25;
        long ageBig = 25000000000000000;
        float f = 5.7f;
        double d = 5.7;
        char c = 'C';
        string str = "damn fool";
        bool boolean = true;

        Console.WriteLine("");

        //naming conventions
        //1. camelCase
        int userAge = 25;
        //2. no shortcuts
        int usrAij = 25; //bad
        //3. meaningful names
        int userAgeInYears = 25;
    }
}