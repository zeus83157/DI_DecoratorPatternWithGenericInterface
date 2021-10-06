using DI_DecoratorPatternWithGenericInterface.ConvertService;
using DI_DecoratorPatternWithGenericInterface.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Component
{
    public class LogDecorator<TRequest, TResponse> : IComponent<TRequest, TResponse>
    {
        private readonly IComponent<TRequest, TResponse> _component;
        private readonly ILogger _logger;
        private readonly IConvertService _convertService;
        public LogDecorator(
            ILogger logger, IConvertService convertService, IComponent<TRequest, TResponse> component)
        {
            _component = component;
            _logger = logger;
            _convertService = convertService;
        }
        public TResponse Execute(TRequest request)
        {
            var response = _component.Execute(request);
            var msgObj = new
            {
                RequestDatetime = DateTime.Now,
                Request = request,
                Responser = request
            };
            _logger.Log(_convertService.SerializeObject(msgObj));
            return response;
        }
    }
}
