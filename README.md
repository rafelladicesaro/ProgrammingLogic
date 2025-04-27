using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details. You can use this as an example for the other methods.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Problem 1: Add a Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Add a method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    // Problem 3: Add a method that updates a field
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    // Problem 4: Add a method that updates a field
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine("The car has been repainted to " + color + ".");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        myCar.Start();   // Calling the Start method
        myCar.Drive(50); // Calling the Drive method with a value of 50

        // Calling the GetDescription method
        string desc = myCar.GetDescription();
        Console.WriteLine(desc);

        // Calling the Repaint method with a value of red
        myCar.Repaint("red"); 

    }
}
