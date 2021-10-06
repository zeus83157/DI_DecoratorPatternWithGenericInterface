using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Scrutor
{
    public class LogDecorator : IComponent
    {
        private readonly IComponent _component;
        public LogDecorator(IComponent component)
        {
            _component = component;
        }
        public void Execute()
        {
            _component.Execute();
            Console.WriteLine("LogDecorator.Execute()");
        }
    }
}
