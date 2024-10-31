using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a number (the main numbers is 0 , 1): ");
        int number = int.Parse(Console.ReadLine());

        if (IsFibonacci(number))
            Console.WriteLine($"{number}  number is in fibonacci serie.");
        else
            Console.WriteLine($"{number}  is not in fibonacci serie.");
    }

    static bool IsFibonacci(int num)
    {
        if (num < 0) return false;

        int a = 0, b = 1;

        while (a <= num)
        {
            if (a == num)
                return true;

            int temp = a + b;
            a = b;
            b = temp;
        }

        return false;
    }
}
