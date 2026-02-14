using System;

class Program
{
    static void Main(string[] args)
    {
        // One-line comment: variable declarations and printing values

        int myInt = 10;
        double myDouble = 25.75;
        char myChar = 'A';
        bool myBool = true;
        string myString = "Hello C#";

        Console.WriteLine("Different variable types:");
        Console.WriteLine("Int: " + myInt);
        Console.WriteLine("Double: " + myDouble);
        Console.WriteLine("Char: " + myChar);
        Console.WriteLine("Bool: " + myBool);
        Console.WriteLine("String: " + myString);

        /*
           Multi-line comment:
           Constant declaration and test
        */

        const double PI = 3.14159;
        Console.WriteLine("\nConstant PI: " + PI);

        // Uncommenting the next line will cause a compile-time error
        // PI = 3.15;

        // Integer operations: increment, decrement, arithmetic
        int number = 20;
        number++; // increment
        number--; // decrement
        int sum = number + 5;
        int product = number * 2;

        Console.WriteLine("\nInteger operations:");
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Sum (+5): " + sum);
        Console.WriteLine("Product (*2): " + product);

        // Float and byte with casting
        float myFloat = 10152466.25f;
        byte myByte = (byte)(5 + myFloat); // explicit cast required

        Console.WriteLine("\nFloat and byte:");
        Console.WriteLine("Float value: " + myFloat);
        Console.WriteLine("Byte value (casted): " + myByte);

        // Print system date and time
        DateTime now = DateTime.Now;
        Console.WriteLine("\nSystem date and time: " + now);
    }
}

