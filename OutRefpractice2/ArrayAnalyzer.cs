namespace OutRefpractice2
{
    public class ArrayAnalyzer
    {
        public void AnalyzeArray(int[] numbers, ref int max, out double average)
        {
            if (numbers.Length == 0)
            {
                max = 0;
                average = 0.0;
                return;
            }

            int sum = 0;
            max = numbers[0];
            sum += numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            average = (double)sum / numbers.Length;
        }
    }
}
