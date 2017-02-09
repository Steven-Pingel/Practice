using System.Linq;
using FizzBuzz;
using Nancy;
using Nancy.ModelBinding;

namespace FizzBuzzSelfHostWeb
{
    public class FizzBuzzModule : NancyModule
    {
        private readonly IFizzBuzzCalculator _calculator;

        public FizzBuzzModule(IFizzBuzzCalculator calculator)
        {
            _calculator = calculator;

            Post["/api/calculate"] = CalulateFizzBuzz;
        }

        private dynamic CalulateFizzBuzz(dynamic parameters)
        {
            var model = this.Bind<FizzBuzzParameterModel>();
            var specifications = model.Specifications.ToDictionary(x => int.Parse(x[0]), x => x[1]);
            var result = _calculator.Calculate(model.StartIndex, model.EndIndex, specifications);

            return Response.AsJson(result.ToList());
        }
    }
}