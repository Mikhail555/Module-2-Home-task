using System;
using System.IO;

namespace PrinciplesDemo
{
    public class YagniExamples
    {
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }

        public class FileReader
        {
            public string ReadFile(string filePath)
            {
                return File.ReadAllText(filePath);
            }
        }

        public class ReportGenerator
        {
            public void GenerateReport()
            {
                Console.WriteLine("Генерация отчёта...");
            }
        }
    }
}
