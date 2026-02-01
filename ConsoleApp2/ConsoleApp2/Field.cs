using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    public class Field
    {
        Player player;
        Monster monster;

        public Field(Player p, Monster m)
        {
            player = p;
            monster = m;
        }

        public bool Fight()
        {
            while (true)
            {
                Console.Clear();
                player.ShowInfo();

                Console.WriteLine("\n====== 전투 ======");
                Console.WriteLine($"몬스터 HP : {monster.monsterHp} | ATK : {monster.monsterAttack}\n");

                Console.WriteLine("1. 일반 공격");

                for (int i = 0; i < player.skills.Count; i++)
                {
                    Skill s = player.skills[i];
                    Console.WriteLine($"{i + 2}. {s.Name} (MP {s.MpCost}, DMG {s.PreviewDamage(player)})");
                }

                Console.WriteLine($"{player.skills.Count + 2}. 도망\n");

                int input = int.Parse(Console.ReadLine());
                int damage = 0;

                if (input == player.skills.Count + 2)
                    return false;

                if (input == 1)
                    damage = player.playerAttack;
                else
                    damage = player.UseSkill(input - 2);

                monster.TakeDamage(damage);

                if (monster.monsterHp <= 0)
                {
                    Console.WriteLine("몬스터 처치!");
                    player.GainExp(monster.monsterExp);
                    player.gold += monster.monsterGold;
                    Console.WriteLine($"골드 +{monster.monsterGold}");
                    Console.WriteLine($"경험치 +{monster.monsterExp}");
                    Console.ReadKey();
                    return true;
                }

                player.PlayerDamaged(monster.monsterAttack);

                if (player.IsDead())
                {
                    player.Die();
                    Console.ReadKey();
                    return true;
                }

                Console.ReadKey();
            }
        }
    }
}
