using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        public Dictionary<int, string> Calculate(int start, int upperBound, Dictionary<int, string> specifications)
        {
            var result = new Dictionary<int, string>();

            for (var i = start; i < upperBound; i++)
            {
                var message = BuildMessage(i, specifications);
                result.Add(i, message);
            }

            return result;
        }

        private string BuildMessage(int dividend, Dictionary<int, string> specifications)
        {
            return specifications
                .Where(spec => dividend.IsDivisibleBy(spec.Key))
                .Aggregate("", (current, spec) => current + spec.Value);
        }
    }
}