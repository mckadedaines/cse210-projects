using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction() : this(0, 1) { }  // default constructor

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(value));
            }
            denominator = value;
        }
    }

    public string ToFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double ToDecimal()
    {
        return (double)numerator / denominator;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter fractions in the format 'numerator/denominator'. Enter 'exit' to stop.");
            while (true)
            {
                Console.Write("Enter a fraction: ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "exit")
                {
                    break;
                }

                string[] parts = input.Split('/');
                if (parts.Length != 2 || !int.TryParse(parts[0], out int numerator) || !int.TryParse(parts[1], out int denominator))
                {
                    Console.WriteLine("Invalid input. Please enter the fraction in the format 'numerator/denominator'.");
                    continue;
                }

                Fraction fraction = new Fraction(numerator, denominator);
                Console.WriteLine(fraction.ToFractionString());
                Console.WriteLine(fraction.ToDecimal());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
