using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Shop
    {
        public static void Enter(Player p)
        {
            while (true)
            {
                Console.Clear();
                p.ShowInfo();

                Console.WriteLine("\n1. HP 포션 (+50) 10G");
                Console.WriteLine("2. MP 포션 (+30) 10G");
                Console.WriteLine("3. 낡은 무기 +2 ATK 50G");
                Console.WriteLine("4. 일반 무기 +5 ATK 120G");
                Console.WriteLine("5. 빛나는 무기 +10 ATK 250G");
                Console.WriteLine("6. 성장의 비약 (+EXP 1) 100G");
                Console.WriteLine("7. 나가기");

                int input = int.Parse(Console.ReadLine());
                if (input == 7) break;

                switch (input)
                {
                    case 1: Buy(p, 10, () => p.playerHp = Math.Min(p.MaxHp, p.playerHp + 50)); break;
                    case 2: Buy(p, 10, () => p.playerMp = Math.Min(p.MaxMp, p.playerMp + 30)); break;
                    case 3: Buy(p, 50, () => p.playerAttack += 2); break;
                    case 4: Buy(p, 120, () => p.playerAttack += 5); break;
                    case 5: Buy(p, 250, () => p.playerAttack += 10); break;
                    case 6: Buy(p, 100, () => p.bonusExp++); break;
                }

                Console.ReadKey();
            }
        }

        static void Buy(Player p, int cost, Action effect)
        {
            if (p.gold < cost)
            {
                Console.WriteLine("골드 부족!");
                return;
            }

            p.gold -= cost;
            effect();
            Console.WriteLine("구매 완료!");
        }
    }
}
