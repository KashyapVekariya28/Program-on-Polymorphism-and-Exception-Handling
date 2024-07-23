using System;

class Calculator
{
    // Compile-time - method overloading
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    // Runtime  - method overriding
    public virtual void DisplayResult(int result)
    {
        Console.WriteLine($"Result of the integer operation: {result}");
    }
}

class AdvancedCalculator : Calculator
{
    public override void DisplayResult(int result)
    {
        Console.WriteLine($"Advanced result: {result}");
    }
}

class Program
{
    static void Main()
    {
        Calculator basicCalculator = new Calculator();
        AdvancedCalculator advancedCalculator = new AdvancedCalculator();

        // Compile-time polymorphism
        int sumInt = basicCalculator.Add(5, 10);
        double sumDouble = basicCalculator.Add(3.5, 2.5);

        Console.WriteLine($"Sum of integers: {sumInt}");
        Console.WriteLine($"Sum of doubles: {sumDouble}");

        // Runtime polymorphism
        basicCalculator.DisplayResult(sumInt);
        advancedCalculator.DisplayResult(sumInt);

    }
}
