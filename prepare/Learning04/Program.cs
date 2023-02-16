using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Eric McCabe", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Connor Ebanks", "Fractions", "4.8", "7-20");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Colt Ford", "English Class", "The stuff about the stuff");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}