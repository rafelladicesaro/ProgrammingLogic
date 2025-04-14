namespace Lab3;

using System;

using System.Collections;

class Program
{
    static void Main()
    {
        // Part 1: Operator Practice
        Console.WriteLine("\n----- Part 1 -----\n");
        int a = 10, b = 5, c = 15;

        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < c));
        Console.WriteLine("a > b && a > c: " + (a > b && a > c));
        Console.WriteLine("a > b || a > c: " + (a > b || a > c));

        // Part 2: Bool Logic
        Console.WriteLine("\n----- Part 2 -----\n");
        bool isRaining = true, haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Part 3: Conditional Logic – Movie Ticket Pricing
        Console.WriteLine("\n----- Part 3 -----\n");

        Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior ticket: $6");
        }

        // Part 4: Using a switch Statement
        Console.WriteLine("\n----- Part 4 -----\n");

        Console.WriteLine("Please enter an integer representing the day of the week (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;

        }

    }
}
