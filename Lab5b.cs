using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[10];
            double[] maxarray = new double[10];
            double max1 = Math.Max(array[0], array[1]);
            double max2 = Math.Max(array[0], array[1]);
            Random RndGen = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RndGen.Next(-20, 20);
            }

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] < 0)
                {
                    array[i] = array[i] * array[i];
                }

            }
            Console.Write("Масив: ");
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] >= max1)
                {
                    max1 = array[j];
                  
                }
                else if (array[j] > max2)
                {
                    max2 = array[j];
                }
            Console.Write(" " + array[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Перше найбільше число {0}", max1);
            Console.WriteLine("Друге найбільше число {0}", max2);
            Console.ReadLine();

        }
    }
}
