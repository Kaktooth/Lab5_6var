using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[10];
            double[] maxarray = new double[10];
            double max1 = 0;
            double max2 = 0;
            double Max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                Max = Math.Max(max1, max2);
                if (array[i]<0)
                {
                    array[i] = Math.Pow(array[i],2);
        
                }

            }
            Console.Write("Масив ");
            for (int j = 0; j < array.Length; j++)
            {   
                maxarray[j] = array[j];
                

               Console.Write(" " + maxarray[j]);
            }
            Array.Sort(maxarray);
            Console.WriteLine();
            Console.WriteLine("Перше найбільше число {0}", maxarray[maxarray.Length-1]);
            Console.WriteLine("Друге найбільше число {0}",maxarray[maxarray.Length-2]);
 
            Console.ReadLine();
           
        }
    }
}
