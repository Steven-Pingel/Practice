using System.Collections.Generic;

namespace FizzBuzz
{
    public interface IFizzBuzzCalculator
    {
        Dictionary<int, string> Calculate(int start, int upperBound, Dictionary<int, string> specifications);
    }
}