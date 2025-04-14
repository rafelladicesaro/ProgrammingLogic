namespace Lab4;


using System;
using System.Collections;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Problem 1: Simple For Loop
        Console.WriteLine ("\n----- Problem 1 -----\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2: Even Numbers from 1 to 20 (Using Modulus Operator)
        Console.WriteLine ("\n----- Problem 2 -----\n");

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Problem 3: While Loop Countdown
        Console.WriteLine ("\n----- Problem 3 -----\n");

        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        // Problem 4: Do/While User Input
        Console.WriteLine ("\n----- Problem 4 -----\n");
        
        int userNum = 0;
        
        do{
            Console.WriteLine("Enter a number greater than 100: ");
            userNum= Convert.ToInt32(Console.ReadLine());

        } while(userNum <= 100);


        // Problem 5: Multiples of 10 from 10 to 1000
        Console.WriteLine("\n----- Problem 5 -----\n");
        
        for (int i = 10; i <= 1000; i += 10)
        {
            Console.WriteLine(i);
        }

        // Problem 6: Multiples of 10 from 10 to 1000
        Console.WriteLine("\n----- Problem 5 -----\n");
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");
        }

    }
}

