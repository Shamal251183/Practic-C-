using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System;

class Calculator
{
    public int num1;
    public int num2;
    public int result;
    public void Add()
    {
        int result = num1 + num2;
        Console.WriteLine("The Result is " + result);
    }
    public void Sum()
    {
        int result = num1 - num2;
        Console.WriteLine("The Result is " + result);
    }
    public void Multi()
    {
        int result = num1 * num2;
        Console.WriteLine("The Result is " + result);
    }
    public void Div()
    {
        int result = num1 / num2;
        Console.WriteLine("The Result is " + result);
    }
    public void Operation()
    {

        string Op = Console.ReadLine();
        switch (Op)
        {
            case "1":
                Add();
                break;
            case "2":
                Sum();
                break;
            case "3":
                Multi();
                break;
            case "4":
                Div();
                break;
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
    }
    public int Read()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    //public Calculator(int n1, int n2)
    //{
    //    num1 = n1;
    //    num2 = n2;
    //}

    //class Call
    //{
    //public static void Main(String[] args)
    //{
    //    Console.BackgroundColor = ConsoleColor.Blue;
    //    Console.ForegroundColor = ConsoleColor.White;
    //    Console.Title = ("Have Fun with Calculator");

    //    Console.WriteLine("Welcome the Calulator");
    //    Console.WriteLine("Choose the below option");
    //    Console.WriteLine("1. Addition");
    //    Console.WriteLine("2. Substraction");
    //    Console.WriteLine("3. Multiplication");
    //    Console.WriteLine("4. Division");
    //    Calculator cal = new Calculator();
    //    Console.WriteLine("Enter Your 1st Number");
    //    cal.num1 = cal.Read();
    //    Console.WriteLine("Enter Your 2nd Number");
    //    cal.num2 = cal.Read();
    //    Console.WriteLine("Seelct the operation type");
    //    cal.Operation();
    //    Console.Beep();
    //}
}