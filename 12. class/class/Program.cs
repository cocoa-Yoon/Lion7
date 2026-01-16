using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Character
    {
        public string name;     //public 어디서나 접근 가능
        public int level;       //private 같은 클래스 내에서만 접근 가능
        public int HP;          //protected 같은 클래스와 상속받은 클래스에서 접근 가능
        public int MP;          // 같은 어셈블리 내에서만 접근 가능
        public int maxHP;
        public int maxMP;

        public Character()      //기본 생성자 초기화 용도로 많이 사용
        {
            name = "Tom";
            level = 1;
            HP = 10;
            MP = 5;
            maxHP = 20;
            maxMP = 10;
        }


        public Character(string _name, int _level, int _HP, int _MP, int _maxHP, int _maxMP)
        {
            name = _name;
            level = _level;
            HP = _HP;
            MP = _MP;
            maxHP = _maxHP;
            maxMP = _maxMP;
        }

        public void showStats()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("level : " + level);
            Console.WriteLine("HP : " + HP);
            Console.WriteLine("MP : " + MP);
            Console.WriteLine("MaxHP : " + maxHP);
            Console.WriteLine("MaxMP : " + maxMP + "\n");
        }
       
        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP < 0) HP = 0;

            Console.WriteLine($"{name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"남은 HP: {HP}/{maxHP}\n");
        }

        public void Heal(int amount)
        {
            HP += amount;
            if (HP > maxHP) HP = maxHP;

            Console.WriteLine($"{name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"현재 HP: {HP}/{maxHP}\n");
        }

    }





    internal class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();

            player1.name = "홍길동";
            player1.level = 1;
            player1.HP = 100;
            player1.MP = 50;
            player1.maxHP = 120;
            player1.maxMP = 100;


            Console.WriteLine("name : " + player1.name);
            Console.WriteLine("level : " + player1.level);
            Console.WriteLine("HP : " + player1.HP);
            Console.WriteLine("MP : " + player1.MP + "\n");

            Character player2 = new Character("Gosu", 20, 500, 200, 600, 300);
            player2.showStats();
            player2.TakeDamage(50);
            player2.Heal(30);

            Character player3 = new Character("slowbabeater", 10, 200, 80, 200, 100);
            player3.showStats();
        }
    }
}
