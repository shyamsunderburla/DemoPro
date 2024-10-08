using ConsoleAppGitHub1.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitHub1
{
    internal class Program
    {
        static void Main(string[] args)
        {int a,b,c;
            Console.WriteLine("enter a value :");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter b value :");
            b = Convert.ToInt32(Console.ReadLine());

           ArithematicOperations obj = new ArithematicOperations();
         c=obj.Add(a,b);
         Console.WriteLine("the sum is ."+c);

            c = obj.sub(a, b);
            Console.WriteLine("the sub is ." + c);
            Console.WriteLine(" Program Completed");
            Console.ReadKey();
        }
    }
}
