using System;

class Program
{
    static void Main()
    {
        // Part 1: Variable Declarations
        int myInt = 25;
        double myDouble = 4.9999;
        float myFloat = 2.71f;
        char myChar = 'A';
        bool myBool = true;
        string myString = "Rafaella Di Cesaro";

        Console.WriteLine("Int: " + myInt);
        Console.WriteLine("Double: " + myDouble);
        Console.WriteLine("Float: " + myFloat);
        Console.WriteLine("Char: " + myChar);
        Console.WriteLine("Bool: " + myBool);
        Console.WriteLine("String: " + myString);

        // Part 2: Type Casting
        double originalDouble = 9.78;
        int castedInt = (int)originalDouble;
        string intToString = Convert.ToString(myInt);
        string boolToString = Convert.ToString(myBool);

        Console.WriteLine("\nOriginal double: " + originalDouble);
        Console.WriteLine("Casted to int: " + castedInt);
        Console.WriteLine("Int to string: " + intToString);
        Console.WriteLine("Bool to string: " + boolToString);

        // Part 3: User Input and Type Conversion
        Console.Write("\nEnter your name please: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, " + name + " You are " + age + " years old.");

        // Part 4: Arithmetic Operators
        int num1 = 10;
        int num2 = 5;

        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));

        // Part 5: Floating Point Precision
        float floatVal = 1.123456789f;
        double doubleVal = 1.123456789;

        Console.WriteLine("Float value: " + floatVal);
        Console.WriteLine("Double value: " + doubleVal);

        // Part 6: Increment and Decrement
        int counter = 10;
        Console.WriteLine("Original value: " + counter);
        counter++;
        Console.WriteLine("After increment: " + counter);
        counter--;
        Console.WriteLine("After decrement: " + counter);
    }
}
