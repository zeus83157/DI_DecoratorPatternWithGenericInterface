using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.ConvertService
{
    public interface IConvertService
    {
        string SerializeObject(object value);
        T DeserializeObject<T>(string value);
    }
}
