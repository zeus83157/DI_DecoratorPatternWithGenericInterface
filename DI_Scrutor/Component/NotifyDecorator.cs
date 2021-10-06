using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Scrutor
{
    public class NotifyDecorator : IComponent
    {
        private readonly IComponent _component;
        public NotifyDecorator(IComponent component)
        {
            _component = component;
        }
        public void Execute()
        {
            _component.Execute();
            Console.WriteLine("NotifyDecorator.Execute()");
        }
    }
}
