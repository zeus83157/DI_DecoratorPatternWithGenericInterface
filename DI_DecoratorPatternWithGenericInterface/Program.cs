using DI_DecoratorPatternWithGenericInterface.Component;
using DI_DecoratorPatternWithGenericInterface.ConvertService;
using DI_DecoratorPatternWithGenericInterface.FakeData;
using DI_DecoratorPatternWithGenericInterface.Logger;
using DI_DecoratorPatternWithGenericInterface.Request;
using DI_DecoratorPatternWithGenericInterface.Response;
using System;

namespace DI_DecoratorPatternWithGenericInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ManualInjectInstancesDemo();
        }

        static private void ManualInjectInstancesDemo()
        {
            // Request001/Response001 or Request002/Response002
            // Manually inject instances
            IComponent<Request001, Response001> component =
                new NotifyDecorator<Request001, Response001>(
                    new LogDecorator<Request001, Response001>(
                        new FileLogger(), new JsonConvertService(),
                        new Component<Request001, Response001>(new JsonConvertService(), new FakeDataService())));

            var data = new Request001
            {
                APICode = "001",
                DateTime = DateTime.Now,
                Guid = Guid.NewGuid()
            };

            component.Execute(data);
        }
    }
}
