public class Statistics
{
    public void AnalyzeNumbers(int number1, ref int number2, out int number3)
    {
        number3 = number1 + number2;

        number2 *= number2;

        Console.WriteLine($"Number1 is : {number1}");
    }

    public int GetNumberFromUser(string userNumbers)
    {
        Console.Write(userNumbers);
        if (int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        return 0;
    }
    public void InputNumbers(out int number1, out int number2)
    {
        number1 = GetNumberFromUser("Enter first number (number1): ");
        number2 = GetNumberFromUser("Enter second number (number2): ");
    }
}