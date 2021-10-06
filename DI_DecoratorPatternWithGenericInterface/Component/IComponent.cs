using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Component
{
    public interface IComponent<TRequest, TResponse>
    {
        TResponse Execute(TRequest request);
    }
}
