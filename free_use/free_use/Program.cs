using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace free_use
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정수를 문자열로, 문자열을 정수로, 2진수를 10진수로, 10진수를 2진수로


            int a = 11;
            string b = a.ToString();

            int c = int.Parse(b);
            Console.WriteLine(c);
           
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x, 2);
            Console.WriteLine(y);

            string z = Convert.ToString(y, 2);
            Console.WriteLine(z);

                   
        }
    }
}
