using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Monster
    {
        public int monsterHp;
        public int monsterAttack;
        public int monsterExp;
        public int monsterGold;

        public void SetMonster(int hp, int atk, int exp, int gold)
        {
            monsterHp = hp;
            monsterAttack = atk;
            monsterExp = exp;
            monsterGold = gold;
        }

        public void TakeDamage(int dmg)
        {
            monsterHp -= dmg;
        }

        public void SelectMonster()
        {
           
            Console.Write("몬스터 선택 (1. 초급 2. 중급 3. 상급) : ");
            int input = int.Parse(Console.ReadLine());
            
            while(true) 
            {
                if(input == 1 || input == 2 || input == 3){
                    switch (input)
                    {
                        case 1: SetMonster(50, 5, 2, 10); break;
                        case 2: SetMonster(150, 10, 5, 30); break;
                        case 3: SetMonster(300, 20, 10, 50); break;
                    }
                    break;
                }
                                
            }
            
        }
    }
}
    