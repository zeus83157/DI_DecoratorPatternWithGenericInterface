using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Response
{
    public class Response002

    {
        public Response002Head Head { get; set; }
        public Response002Content Content { get; set; }
    }

    public class Response002Head
    {
        public Guid ResponseID { get; set; }
        public DateTime ResponseDateTime { get; set; }
    }

    public class Response002Content
    {
        public bool Status { get; set; }
        public string Description { get; set; }
        public Guid OrderID { get; set; }
        public List<Record> Records { get; set; }
    }

    public class Record
    {
        public string Name { get; set; }
        public int InventoryCount { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
