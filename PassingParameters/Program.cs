using System;

namespace PassingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("pass by value");
            //int a;
            //a = 5;
            //Console.WriteLine("From main initial value of a: " +a);
            //ChangeVal(a);
            //Console.WriteLine("From main new value of a : " + a);
            //Console.WriteLine("Call by Reference");
            //int b;
            //b = 10;
            //Console.WriteLine("From main initial value of b: " + b);
            //ChangeVal2(ref b);
            //Console.WriteLine("From main new value of b : " + b);
            //Console.WriteLine("Swapping");
            //int x = 4;
            //int y = 5;
            //swap(ref x,ref y);
            //Console.WriteLine("Swapped values x = " + x + "y = " + y);
            Console.WriteLine("Area and Perimeter of Rectangle");
            int l=2, b=3;
            double area=0, perimeter=0;
            AreaPerimeter(l,b,ref area, ref perimeter);
            Console.WriteLine("Area = " + area +"Perimeter" + perimeter);
            Console.WriteLine("Math Operations using call by value and call by Reference");
            int x = 3, y = 2;
            int add = 0, sub = 0, mul = 0;
            mathOperations(x, y, ref add, ref sub, ref mul);
            Console.WriteLine("Addition = " + add);
            Console.WriteLine("Multiplication = " + mul);
            Console.WriteLine("Substraction = " + sub);
            Console.WriteLine("Consructors");
            Rectangle r = new Rectangle();
            r.printData();
            new Rectangle();
            
        }
        static void ChangeVal(int n)
        {
            Console.WriteLine("Initial value of n from function: " + n);
            n = 20;
            Console.WriteLine("From function new value of n: " + n);
        }
        static void ChangeVal2(ref int n)
        {
            Console.WriteLine("Initial value of n from function: " + n);
            n = 20;
            Console.WriteLine("From function new value of n: " + n);
        }
        static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            
        }
        static void AreaPerimeter(int l, int b, ref double area, ref double perimeter)
        {
            area = l * b;
            perimeter = 2*(l + b);

        }
        static void mathOperations(int x, int y, ref int add, ref int sub, ref int mul)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;
         }
    }
}
