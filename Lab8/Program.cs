namespace Lab8;

using System;

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();  // Base class reference to base class
        Animal myCat = new Cat();        // Base class reference to derived class Cat
        Animal myDog = new Dog();        // Base class reference to derived class Dog

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}

