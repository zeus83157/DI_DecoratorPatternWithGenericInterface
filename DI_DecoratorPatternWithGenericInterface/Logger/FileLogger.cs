using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Logger
{
    public class FileLogger : ILogger
    {
        public void Log(string msg)
        {
            var folderPath = "Log";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            using (var sw = new StreamWriter($@"{folderPath}\{DateTime.Now:yyyyMMdd}.txt", true))
            {
                sw.WriteLine(msg);
                sw.WriteLine("========================");
            }
        }
    }
}
