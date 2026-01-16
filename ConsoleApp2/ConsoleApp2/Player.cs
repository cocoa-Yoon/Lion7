using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Player
    {
        int input;
        public string playerJob;
        public int playerHp;
        public int playerMp;
        public int playerAttack;
        public int playerLevel;
        public int plaerExp;

        public void SetPlayer(string job, int hp, int mp, int attack)
        {
            playerJob = job;
            playerHp = hp;
            playerMp = mp;
            playerAttack = attack;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"job : {playerJob}");
            Console.WriteLine($"HP : {playerHp}");
            Console.WriteLine($"MP : {playerMp}");
            Console.WriteLine($"attack : {playerAttack}");
        }


        public void SelectJob()
        {
            Console.WriteLine("select your job (1. warrior 2. mage 3. thief) : ");
            input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    SetPlayer("warrior", 100, 10, 10);
                    ShowInfo(); break;
                case 2:
                    SetPlayer("mage", 60, 6, 100);
                    ShowInfo(); break;
                case 3:
                    SetPlayer("theif", 80, 8, 30);
                    ShowInfo(); break;
            }
        }




    }
}
