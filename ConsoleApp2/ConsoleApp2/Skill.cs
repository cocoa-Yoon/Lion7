using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Skill
    {
        public string Name;
        public int MpCost;
        public int Power;

        public Skill(string name, int mp, int power)
        {
            Name = name;
            MpCost = mp;
            Power = power;
        }

        public int PreviewDamage(Player p)
        {
            return p.playerAttack * Power;
        }

        public int Use(Player p)
        {
            if (p.playerMp < MpCost)
            {
                Console.WriteLine("MP 부족!");
                return 0;
            }

            p.playerMp -= MpCost;
            int dmg = PreviewDamage(p);
            Console.WriteLine($"{Name} 사용! ({dmg} 데미지)");
            return dmg;
        }
    }
}
