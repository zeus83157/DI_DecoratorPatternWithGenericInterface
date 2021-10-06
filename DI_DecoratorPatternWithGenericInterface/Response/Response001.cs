using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Response
{
    public class Response001
    {
        public Response001Head Head { get; set; }
        public Response001Content Content { get; set; }
    }

    public class Response001Head
    {
        public Guid ResponseID { get; set; }
        public DateTime ResponseDateTime { get; set; }
    }

    public class Response001Content
    {
        public bool Status { get; set; }
        public string Description { get; set; }
        public int RecordCount { get; set; }
    }
}
