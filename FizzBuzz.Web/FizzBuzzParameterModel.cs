using System.Collections.Generic;

namespace FizzBuzzSelfHostWeb
{
    public class FizzBuzzParameterModel
    {
        public List<List<string>> Specifications { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}