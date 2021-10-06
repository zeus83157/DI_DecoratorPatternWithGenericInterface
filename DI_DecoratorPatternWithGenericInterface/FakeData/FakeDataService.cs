using System;
using System.Collections.Generic;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.FakeData
{
    public class FakeDataService : IFakeDataService
    {
        public string GetFakeData(string requestData)
        {
            if (requestData.Contains("\"APICode\":\"001\""))
                return "{\"Head\":{\"ResponseID\":\"ff216548-05ab-4be6-9238-28bec9f8aef5\",\"ResponseDateTime\":\"2021-10-02T21:20:22.4263898+08:00\"},\"Content\":{\"Status\":true,\"Description\":\"Success Update Data\",\"RecordCount\":12}}";
            else
                return "{\"Head\":{\"ResponseID\":\"f354f5f8-c30d-48ee-9bb7-713c8c64438f\",\"ResponseDateTime\":\"2021-10-02T21:32:12.318938+08:00\"},\"Content\":{\"Status\":true,\"Description\":\"Success Update Data\",\"OrderID\":\"cf99a8bd-f8d4-401d-8025-4ff7bfc8f839\",\"Records\":[{\"Name\":\"Book\",\"InventoryCount\":50,\"UpdateDateTime\":\"2021-10-02T21:32:12.3209396+08:00\"},{\"Name\":\"pencil\",\"InventoryCount\":23,\"UpdateDateTime\":\"2021-10-02T21:32:12.3209396+08:00\"}]}}";
        }
    }
}
