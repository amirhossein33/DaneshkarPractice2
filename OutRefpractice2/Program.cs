namespace OutRefpractice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var analyzer = new ArrayAnalyzer();

            int max = 0;
            analyzer.AnalyzeArray(numbers, ref max, out double average);
            Console.WriteLine($"Maximum value in the array: {max}");
            Console.WriteLine($"Average of the array: {average:F2}");
            Console.ReadKey();
        }
    }
}