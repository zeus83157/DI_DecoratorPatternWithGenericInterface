using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.FakeData
{
    public interface IFakeDataService
    {
        string GetFakeData(string requestData);
    }
}
