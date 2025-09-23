using System;

class Program
{
    static void Main(string[] args)
    {
        string DNI;
        string name;
        int age;
        double height;
        bool isEmployed;

        // Read data
        Console.Write("Enter your DNI: ");
        DNI = Console.ReadLine() ?? "";

        Console.Write("Enter your name: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter your height (in meters): ");
        height = double.Parse(Console.ReadLine());

        Console.Write("Are you employed? (true/false): ");
        isEmployed = bool.Parse(Console.ReadLine());

        // Show data
        Console.WriteLine("\n--- User Information introduced ---");
        Console.WriteLine($"DNI: {DNI}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height} m");
        Console.WriteLine($"Employed: {isEmployed}");

        Person person = new Person(DNI, name, age, height, isEmployed);
        Console.WriteLine("\n--- User Information from Person object ---");
        Console.WriteLine(person);

    }
}