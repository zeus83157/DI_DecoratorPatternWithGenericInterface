using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Request
{
    public class Request002
    {
        public DateTime DateTime { get; set; }
        public Guid Guid { get; set; }
        public string APICode { get; set; }
        public Request002Content Content { get; set; }

    }
    public class Request002Content
    {
        public string Name { get; set; }
        public Guid Guid { get; set; }
    }
}
