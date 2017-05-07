using System;
using Microsoft.Office.Interop.Excel;

namespace ConsoleApplication
{
    public class Program
    {
        public static void myHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myHelloWorld();
            int i =0 ;
            for (i=0; i < 10 ; i++)
            {
                Console.Beep(1000,100);
            }
        }
    }
}
