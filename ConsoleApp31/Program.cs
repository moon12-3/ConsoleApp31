using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if(x%3 == 0)
                {
                    Console.WriteLine("__@");
                } else if(x % 3 == 1)
                {
                    Console.WriteLine("__^@");
                } else 
                {
                    Console.WriteLine("^__@");
                }
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
