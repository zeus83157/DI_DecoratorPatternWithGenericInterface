using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.ConvertService
{
    public class JsonConvertService : IConvertService
    {
        public T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
