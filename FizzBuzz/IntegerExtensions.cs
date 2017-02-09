namespace FizzBuzz
{
    public static class IntegerExtensions
    {
        public static bool IsDivisibleBy(this int value, int divisor)
        {
            return divisor != 0 && value % divisor == 0;
        }
    }
}