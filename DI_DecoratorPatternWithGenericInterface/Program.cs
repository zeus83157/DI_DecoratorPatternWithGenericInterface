using Autofac;
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
            //ManualInjectInstancesDemo();
            AutofacInjectInstancesDemo();
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

        static private void AutofacInjectInstancesDemo()
        {
            // Request001/Response001 or Request002/Response002
            // Autofac inject instances
            var builder = new ContainerBuilder();
            builder.RegisterType<JsonConvertService>().As<IConvertService>();
            builder.RegisterType<FileLogger>().As<ILogger>();
            builder.RegisterType<FakeDataService>().As<IFakeDataService>();

            builder.RegisterGeneric(typeof(Component<,>)).As(typeof(IComponent<,>));
            builder.RegisterGenericDecorator(typeof(LogDecorator<,>), typeof(IComponent<,>));
            builder.RegisterGenericDecorator(typeof(NotifyDecorator<,>), typeof(IComponent<,>));

            IContainer container = builder.Build();
            IComponent<Request001, Response001> component = container.Resolve<IComponent<Request001, Response001>>();

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
