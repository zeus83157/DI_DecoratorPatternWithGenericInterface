using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Scrutor
{
    public class Component : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("Component.Execute()");
        }
    }
}
