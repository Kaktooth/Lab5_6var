using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Progm
    {
        static void Main(string[] args)
        {

            double[] arr = new double[10];
          
            Console.WriteLine("Клавіші:");
            Console.WriteLine("Ввести за допомогою");
            Console.WriteLine("клавіатури         1");
            Console.WriteLine("рандомом           2");
            int cswitch = int.Parse(Console.ReadLine());

            switch (cswitch)
            {
                case 1:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = EnterKeys();
                        if (arr[i] < 0)
                        {
                            arr[i] = Math.Pow(arr[i], 2);

                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = EnterRandom();
                        if (arr[i] < 0)
                        {
                            arr[i] = Math.Pow(arr[i], 2);

                        }
                    }
                    break;
                default:
                    Console.WriteLine("Помилка команди");
                    break;
            }
            Console.Write("Масив ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(" " + arr[j]);
            }

            double max1 = 0;
            double max2 = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] >= max1)
                {
                    max1 = arr[j];

                }

            }
            for (int j = 0; j < arr.Length; j++)
            {
             
                if (arr[j] >= max2&&arr[j] != max1)
                {
                    max2 = arr[j];
                }

            }



            Console.WriteLine();
            Console.WriteLine("Перше найбільше число {0}", max1);
            Console.WriteLine("Друге найбільше число {0}", max2);
            Console.ReadLine();

        }
        static double EnterKeys()
        {
            double enter = 0;
            enter = int.Parse(Console.ReadLine());
            return enter;
        }
        static double EnterRandom()
        {
            Random RndGen = new Random();
            double enter = 0;
            enter = RndGen.Next(-100, 100);
            return enter;
        }

    }
}
