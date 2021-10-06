using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Logger
{
    public interface ILogger
    {
        void Log(string msg);
    }
}
