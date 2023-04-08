using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] numbers = input.Replace(".", ",").Split(' ');
            double[] components = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (double.TryParse(numbers[i], out double num))
                {
                    components[i] = num;
                }
                else
                {
                    Console.WriteLine($"Ошибка преобразования числа {numbers[i]} в тип double.");
                    return;
                }
            }

            double sumSquares = 0;

            foreach (double component in components)
            {
                double value = component;
                sumSquares += value * value;
            }

            double result = Math.Sqrt(sumSquares);
            string res;

            if (result % 1 == 0)
            {
                res = result.ToString("0.0").Replace(",", ".");
            }
            else
            {
                res = result.ToString().Replace(",", ".");
            }

            Console.WriteLine(res);
        }
    }

}
