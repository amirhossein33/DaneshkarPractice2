class Program
{
    static void Main(string[] args)
    {
        var statistics = new Statistics();
        statistics.InputNumbers(out int number1, out int number2);
        Console.WriteLine($"Number1: {number1}");
        Console.WriteLine($"Number2: {number2}"); 

        statistics.AnalyzeNumbers(number1, ref number2, out int number3);
        Console.WriteLine($"Number1 is: {number1}");
        Console.WriteLine($"Number2 is: {number2}");
        Console.WriteLine($"Number3 is: {number3}");
    }
}
