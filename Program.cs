using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n=int.Parse(Console.ReadLine());
            int x = 0;
            string s1;
            string s2 = "++x";
            string s3 = "x++";
            string s4 = "--x";
            string s5 = "x--";
            for(int i = 0; i < n; i++)
            { 
                s1 = Console.ReadLine();
                if (s1 == s2 || s1 == s3)
                    x = x + 1;
                else
                    x = x - 1;
            }
            Console.WriteLine(x);
        }
    }
}
