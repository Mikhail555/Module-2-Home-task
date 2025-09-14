using System;

namespace PrinciplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Принцип DRY ===");
            var logger = new DryExamples.Logger();
            logger.Log("error", "Что-то пошло не так");
            logger.Log("info", "Программа запущена");

            var db = new DryExamples.DatabaseService();
            db.Connect();

            var logService = new DryExamples.LoggingService();
            logService.Log("Сохранение лога в БД");

            Console.WriteLine("\n=== Принцип KISS ===");
            var numbers = new int[] { -5, 0, 1, 3, -2, 7 };
            var kiss = new KissExamples();

            kiss.ProcessNumbers(numbers);
            kiss.PrintPositiveNumbers(numbers);
            Console.WriteLine($"Divide(10, 0) = {kiss.Divide(10, 0)}");

            Console.WriteLine("\n=== Принцип YAGNI ===");
            var user = new YagniExamples.User { Name = "Алиса", Email = "alice@example.com" };
            Console.WriteLine($"User: {user.Name}, {user.Email}");

            var reader = new YagniExamples.FileReader();
            Console.WriteLine($"Содержимое test.txt: {reader.ReadFile("test.txt")}");

            var report = new YagniExamples.ReportGenerator();
            report.GenerateReport();
        }
    }
}
