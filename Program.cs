using System;
using System.Collections.Generic;

namespace lab2_16
{
    class Program
    {
        static void Main()
        {
            List<double> results = new()
            {
                GetFunction()
            };

            GetResults(results.ToArray());
        }
        private static double GetFunction()
        {
            Console.Write("Введите X: ");
            double argX = double.Parse(Console.ReadLine());

            Console.Write("Введите радиус: ");
            double argRadius = double.Parse(Console.ReadLine());

            double lowerLimit = -10.0;
            double upperLimit = 8.0;

            if (argX < lowerLimit || argX > upperLimit)
            {
                Console.WriteLine("X за пределами функции");
                throw new Exception();
            }

            if (argRadius < 0 || argRadius >= 5.0)
            {
                Console.WriteLine("Радиус не соответствует границам или <0");
                throw new Exception();
            }


            if (argX < -8.0)
            {
                return -argRadius;
            }

            if (argX < -argRadius)
            {
                return argRadius / (8.0 - argRadius) * (argX + argRadius);
            }
            if (argX < argRadius)
            {
                return -Math.Sqrt(argRadius * argRadius - argX * argX);
            }
            if (argX < 5.0)
            {
                return 2.0 / (5.0 - argRadius) * (argX - argRadius);
            }
            return 3.0;


        }   
        private static void GetResults(double[] results)
        {
            string outputResult = "";
            string outputPattern = "result";

            for (int i = 0; i < results.Length; i++)
            {
                outputResult += (outputPattern + " = " + results[i] + "\n");
            }

            Console.WriteLine(outputResult);
        }
             
    }
}
