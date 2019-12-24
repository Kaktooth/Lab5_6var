using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            double[] maxarray = new double[10];
            Console.WriteLine("Клавіші:");
            Console.WriteLine("Ввести за допомогою");
            Console.WriteLine("клавіатури         1");
            Console.WriteLine("рандомом           2");
            double cswitch = double.Parse(Console.ReadLine());
            arr = EnterKey(cswitch);
            Console.Write("Масив ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(" " + arr[j]);
            }
            double max1 = MaxValue1(arr);
            double max2 = MaxValue2(max1, arr);
            Console.WriteLine();
            Console.WriteLine("Перше найбільше число {0}", max1);
            Console.WriteLine("Друге найбільше число {0}", max2);
            Console.ReadLine();
        }
        static double[] EnterKey(double cswitch)
        {
            double[] array = new double[10];
            Random RndGen = new Random();
            switch (cswitch)
            { 
                case 1:
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        if (array[i] < 0)
                        {
                            array[i] = Math.Pow(array[i], 2);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < array.Length; i++)
                    { 
                        array[i] = RndGen.Next(-20, 20); ;
                        if (array[i] < 0)
                        {
                            array[i] = Math.Pow(array[i], 2);
                        }
                    }
                    break;
                default:
                   Console.WriteLine("Помилка команди");
                    break;
            }
            return array;
        }
        static double MaxValue1(double[] arr)
        {
            double max1 = arr.Max();
            return max1;
        }
        static double MaxValue2(double max1 ,double[] arr)
        {
            double max2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max1)
                {
                    arr = arr.Where(val => val != max1).ToArray();
                    max2 = arr.Max();
                }
            }
            return max2;
        }
    }
}
