using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Character
    {
        protected string name;
        protected int level;
        protected int maxHp;
        protected int hp;
        protected int attack;
        protected int defense;
        
        public Character(string characterName)
        {
            name = characterName;
            level = 1;
            maxHp = 100;
            hp = maxHp;
            attack = 30;
            defense = 20;

            Console.WriteLine($"케릭터 {name} 생성!");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"HP : {hp}/{maxHp}");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
        }
    }

    class Warrior : Character
    {
        private int rage;

        public Warrior(string name) : base(name)
        {
            //name : "전사";  //base.name과 같다. 부모꺼 명시적 호출
            attack = 60;
            defense = 40;
            maxHp = 150;
            hp = maxHp;
            rage = 0;

            Console.WriteLine($"직업 : 전사");
        }
        public void ShowInfo2()
        {
            base.ShowInfo();
            Console.WriteLine($"분노 : {rage}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior w = new Warrior("홍길동");

            w.ShowInfo2();

        }
    }
}
