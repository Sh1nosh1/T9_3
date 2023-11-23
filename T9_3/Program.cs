using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T9_3
{
    internal class Program
    {
        static void Output(List<double> numbers)
        {
            foreach (var elem in numbers)
            {
                Write($"{elem};\t");
            }
            WriteLine();
        }

        static void Remove(List<double> numbers)
        {
            int i = 0;
            while(numbers[i] <= 0)
            {
               numbers.RemoveAt(i+2);
               i++;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                var numbers = new List<double>() {-4.6, 46.6, 6.4, 3.6, -1.6, -4.7};

                Output(numbers);

                Remove(numbers);
                WriteLine();
                Output(numbers);
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
