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
            int playerHealth = 5;
            int playerStrength = 8;
            double playerIntelligence = 7.5;
            decimal playerLuck = 2.4m;
            const float playerSize = 1.05f;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━  케릭터 정보 ━━━━━━━━━━━━━━━━━┓");
            Thread.Sleep(1000);
            Console.WriteLine($"┃          플레이어 체력              {playerHealth}         ┃");
            Thread.Sleep(1000);
            Console.WriteLine($"┃          플레이어 힘                {playerStrength}         ┃");
            Thread.Sleep(1000);
            Console.WriteLine($"┃          플레이어 지능              {playerIntelligence}       ┃");
            Thread.Sleep(1000);
            Console.WriteLine($"┃          플레이어 운                {playerLuck}       ┃");
            Thread.Sleep(1000);
            Console.WriteLine($"┃          플레이어 크기              {playerSize}      ┃");
            Thread.Sleep(1000);
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Thread.Sleep(1000);



        }
    }
}
