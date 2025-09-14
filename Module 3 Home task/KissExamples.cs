using System;

namespace PrinciplesDemo
{
    public class KissExamples
    {
        // Простая проверка без всяких вложений
        public void ProcessNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return;

            foreach (var number in numbers)
                if (number > 0)
                    Console.WriteLine(number);
        }

        // Упрощённый вывод
        public void PrintPositiveNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            foreach (var n in numbers)
                if (n > 0)
                    Console.WriteLine(n);
        }

        // Без try/catch для нуля
        public int Divide(int a, int b)
        {
            if (b == 0) return 0;
            return a / b;
        }
    }
}
