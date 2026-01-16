using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment
{
    class Monster
    {
        public string name;
        public int level;
        public int hp;
        public int attack;
        public int defense;
        public int expReaward;

        public Monster()
        {
            name = "슬라임";
            level = 1;
            hp = 50;
            attack = 10;
            defense = 5;
            expReaward = 10;
        }

        public Monster(string monsterName, int monsterLevel)
        {
            name = monsterName;
            level = monsterLevel;
            hp = 50 * level;
            attack = 10 * level;
            defense = 5 * level;
            expReaward = 10 * level;
        }

        public void ShowStats()
        {
            Console.WriteLine($"{name} (Lv.{level})");
            Console.WriteLine($"HP : {hp}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
            Console.WriteLine($"경험치 : {expReaward}\n");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Monster slime = new Monster();
            slime.ShowStats();

            Monster goblin = new Monster("고블린", 5);
            goblin.ShowStats();

            Console.WriteLine("==== 필드 몬스터 ==== \n");
            Monster[] monsters = new Monster[3];
            monsters[0] = new Monster("늑대", 3);
            monsters[1] = new Monster("오크", 7);
            monsters[2] = new Monster("트롤", 10);
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i].ShowStats();
            }

        }
    }
}
