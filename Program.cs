using System;

class Program
{
    static void Main()
    {
        string octal1 = "56";
        string octal2 = "2";

        int decimal1 = Convert.ToInt32(octal1, 8);
        int decimal2 = Convert.ToInt32(octal2, 8);
        int resultDecimal = decimal1 / decimal2;

        string resultOctal = Convert.ToString(resultDecimal, 8);

        Console.WriteLine("Result: " + resultOctal);
        Console.ReadLine();
    }
}
    


