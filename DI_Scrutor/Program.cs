using Microsoft.Extensions.DependencyInjection;
using System;

namespace DI_Scrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection sc = new ServiceCollection();
            sc.AddScoped<IComponent, Component>();
            sc.Decorate<IComponent, LogDecorator>();
            sc.Decorate<IComponent, NotifyDecorator>();

            IServiceProvider sp = sc.BuildServiceProvider();

            IComponent compoent = sp.GetService<IComponent>();
            compoent.Execute();
        }
    }
}
