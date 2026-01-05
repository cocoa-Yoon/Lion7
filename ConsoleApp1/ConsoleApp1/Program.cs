using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int level = 9, vigor = 15, mind = 10, endurance = 11, strength = 14;
            int dexterity = 13, intelligence = 9, faith = 9, arcane = 7;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃     Level         {level       }                     ┃");
            Console.WriteLine($"┃     Vigor         {vigor       }                    ┃");
            Console.WriteLine($"┃     Mind          {mind        }                    ┃");
            Console.WriteLine($"┃     Endurance     {endurance   }                    ┃");
            Console.WriteLine($"┃     Strength      {strength    }                    ┃");
            Console.WriteLine($"┃     Dexterity     {dexterity   }                    ┃");
            Console.WriteLine($"┃     Intelligence  {intelligence}                     ┃");
            Console.WriteLine($"┃     Faith         {faith       }                     ┃");
            Console.WriteLine($"┃     Arcane        {arcane}                     ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }
    }
}
