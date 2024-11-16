using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_c_
{
    internal class Loop
    {
        public void FirstTenNaturalNum()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
            }
        }
        public void SumOfFirstTenNaturalNum()
        {
            int sum = 0;
            Console.Write("\nThe first 10 natural Number is\n");
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write(i);
            }
            Console.Write("\nThe sum is = " + sum);
        }
        public void SumOfnNaturalNum()
        {
            int sum = 0;
            Console.WriteLine("Enter any number as program input");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The First " + num + " natural number is : ");
                for (int i = 1; i <= num; i++)
                {
                    sum = sum + i;
                    Console.Write(i);
                }
                Console.Write("\nThe sum of Natural Number upto " + num + " turms : " + sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public void AverageSum()
        {
            double sum = 0;
            Console.WriteLine("Enter any 10 numbers as program input");
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                }
                double avg = sum / 10;
                Console.WriteLine("The sum of 10 no is : " + sum);
                Console.WriteLine("The Average is :" + avg);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter Valide Number");
            }
        }

        ////*****User input using Array****
        //public void AverageSum()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter any 10 numbers as program input");
        //        double[] num = new double[10];
        //        double sum = 0;
        //        for (int i = 0; i < 10; i++)
        //        {
        //            num[i] = Convert.ToDouble(Console.ReadLine());
        //            sum += num[i];
        //        }
        //        double avg = sum / 10;
        //        Console.WriteLine("The sum of 10 no is : " + sum);
        //        Console.WriteLine("The Average is :" + avg);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}
        public void triangle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void reverseTrangle()
        {
            for(int i = 5; i > 0; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*") ;
            }
        }
        public void Table()
        {
            Console.WriteLine("Enter any number");
            int num =Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i <= 10; i++)
            {
                Console.WriteLine($"{num}X{i}= {num*i}");
            }
        }
        public void Count()
        {
            int num = 12345;
            //int num1 = 0;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine($"The length of number is {count}");
        }
        public void Fraction()
        {
            Console.WriteLine("Enter number");
            int input = Convert.ToInt32(Console.ReadLine());
            int outPut=1;      
            
            for (int i=1; i <= input; i++)
            {
               outPut = outPut * i;                
            }
            Console.WriteLine($"Fraction of {input} is {outPut})");
        }
        public void SumOfDigits()
        {
            int num = 123;
            int sum = 0;
            int num1=num;
            while(num > 0)
            {
                num1 = num % 10;
                sum += num1;
                num = num / 10;
            }
            Console.WriteLine($"The Sum Of Digit is {sum}");
        }
        public void LengthOfString()
        {
            string str = "Hello";
            Console.WriteLine($"Lenth of string is {str.Length}");
        }
        public static void Main(string[] args)
        {
            Loop loop = new Loop();
            //loop.FirstTenNaturalNum();
            //Console.WriteLine("\n");
            //loop.SumOfFirstTenNaturalNum();
            //Console.WriteLine("\n");
            //loop.SumOfnNaturalNum();
            //Console.WriteLine("\n");
            //loop.AverageSum();
            //Console.WriteLine("\n");
            //loop.triangle();
            //Console.WriteLine("\n");
            //loop.reverseTrangle();
            //Console.WriteLine("\n");
            //loop.Table();
            //Console.WriteLine("\n");
            //loop.Count();
            //Console.WriteLine("\n");
            //loop.Fraction();
            //Console.WriteLine("\n");
            //loop.SumOfDigits();
            loop.LengthOfString();
        }
    }
}
