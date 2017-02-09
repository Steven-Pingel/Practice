using Autofac;
using FizzBuzz;
using Nancy.Bootstrappers.Autofac;

namespace FizzBuzzSelfHostWeb
{
    public class CustomBootstrapper
    {
        public class Bootstrapper : AutofacNancyBootstrapper
        {
            protected override void ConfigureApplicationContainer(ILifetimeScope container)
            {
                container.Update(builder => builder.RegisterType<FizzBuzzCalculator>().As<IFizzBuzzCalculator>().SingleInstance());
            }
        }
    }
}