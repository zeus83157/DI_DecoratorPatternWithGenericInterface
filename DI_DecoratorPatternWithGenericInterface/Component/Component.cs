using DI_DecoratorPatternWithGenericInterface.ConvertService;
using DI_DecoratorPatternWithGenericInterface.FakeData;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Component
{
    public class Component<TRequest, TResponse> : IComponent<TRequest, TResponse>
    {
        readonly IConvertService _convertService;
        readonly IFakeDataService _fakeDataService;
        public Component(IConvertService convertService, IFakeDataService fakeDataService)
        {
            _convertService = convertService;
            _fakeDataService = fakeDataService;
        }

        public TResponse Execute(TRequest request)
        {
            var response = _fakeDataService.GetFakeData(_convertService.SerializeObject(request));
            return _convertService.DeserializeObject<TResponse>(response);
        }
    }
}
