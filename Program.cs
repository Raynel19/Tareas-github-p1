using System;

class DemoDataTypes
{
    static void Main(string[] args)
    {
        // ===== Variable declarations with values =====

        int age = 18;
        decimal price = 150.99m;
        char letter = 'Z';
        bool isActive = false;
        string message = "C# practice program";

        Console.WriteLine("=== Variable values ===");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Letter: {letter}");
        Console.WriteLine($"IsActive: {isActive}");
        Console.WriteLine($"Message: {message}");

        /*
           Constant example section
           Constants cannot be changed after declaration
        */

        const int MAX_USERS = 100;
        Console.WriteLine("\nConstant MAX_USERS: " + MAX_USERS);

        // If you try to change it, the program will not compile
        // MAX_USERS = 200;

        // ===== Integer math operations =====

        int counter = 5;

        Console.WriteLine("\n=== Integer operations ===");
        Console.WriteLine("Start value: " + counter);

        counter += 1; // increment using +=
        Console.WriteLine("After increment: " + counter);

        counter -= 2; // decrement using -=
        Console.WriteLine("After decrement: " + counter);

        int square = counter * counter;
        int division = square / 2;

        Console.WriteLine("Square: " + square);
        Console.WriteLine("Square / 2: " + division);

        // ===== Float and byte conversion example =====

        float bigFloat = 10152466.25f;
        float sumFloat = bigFloat + 5;

        Console.WriteLine("\n=== Float and byte conversion ===");
        Console.WriteLine("Float formatted: " + bigFloat.ToString("F2"));
        Console.WriteLine("Float + 5: " + sumFloat.ToString("F2"));

        // Explicit cast to byte (overflow will occur)
        byte smallByte = (byte)sumFloat;
        Console.WriteLine("Byte after cast: " + smallByte);

        // ===== System date and time =====

        DateTime systemNow = DateTime.Now;
        Console.WriteLine("\nSystem date: " + systemNow.ToShortDateString());
        Console.WriteLine("System time: " + systemNow.ToLongTimeString());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

