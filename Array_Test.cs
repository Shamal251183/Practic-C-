using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_c_
{
    internal class Array_Test
    {       
        // Array_Test(int[] arr)
        //{
        //    this.array = arr;
        //}
        public void MaxOrMinVal()
        {
            int[] array = new int[] { 45, 25, 21 };
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                else
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"The Maximum Number is {max}");
            Console.WriteLine($"The Minimum Number is {min}");
        }     
        public void SumOfArrayElement()
        {
            Console.WriteLine("Enter any 3 Numbers");
            int[] array = new int[3];
            int sum = 0;
            for(int i = 0;i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);

        }
        //public static void Main(string[] args)
        //{
        //    Array_Test Test = new Array_Test();
        //    //Test.MaxOrMinVal();
        //    //Test.SumOfArrayElement();
            
        //}

    }
}
