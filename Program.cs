namespace Assignment_5._1._2
{
    class Program
    {
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
        }
    }
}