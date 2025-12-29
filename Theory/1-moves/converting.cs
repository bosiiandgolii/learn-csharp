using System;

class Program
{
    static void Main()
    {
        // Converting between types
        int intValue = 42;

        System.Console.WriteLine(intValue.convertToDouble());
        System.Console.WriteLine(intValue.convertToString());
        
        // Extension methods for converting types
        System.Console.WriteLine(intValue.ToString());
        System.Console.WriteLine(Convert.ToDouble(intValue));

        // Parsing strings to numbers
        string strValue = "123";
        int parsedInt = int.Parse(strValue);

        // Safe parsing with TryParse
        string invalidStr = "abc";
        bool success = int.TryParse(invalidStr, out int result);
        
    }
}
