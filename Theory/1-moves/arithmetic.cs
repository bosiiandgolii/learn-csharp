using System;

class Program
{
    static void Main()
    {
        int x = 5;
        int y = 10;
        
        //addition
        int sum = x + y;

        //subtraction
        int difference = x - y;

        //multiplication
        int product = x * y;

        //division
        int quotient = y / x;

        //modulus
        int remainder = y % x;

        //increment
        x++;
        ++y;

        //decrement
        x--;
        --y;

        //compound assignment
        int age = 18;
        age += 5;
        age -= 3;
        age *= 2;
        age /= 4;
        age %= 3;
    
        // () has the highest precedence
        int result = (x + y) * (x - y);
    
    }
}