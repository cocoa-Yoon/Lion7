using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace free_use
{
    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();
    }

    interface IDefendable
    {
        void Defend();
        int GetDefendPower();
    }

    class Knight : IAttackable, IDefendable
    {
        public string name;
        public int attackPower;
        private int defense;

        public Knight(string name, int damage)
        {
            this.name = name;
            attackPower = damage;
            defense = 10;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 {target} 공격");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public void Defend()
        {
            Console.WriteLine("기사가 방어모드 중입니다");
        }
        public int GetDefendPower()
        {
            return defense;
        }
    }
    
    class Mage : IAttackable
    {
        public string name;
        public int attackPower;

        public Mage(string name, int damage)
        {
            this.name = name;
            attackPower = damage;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"마법으로 {target} 공격");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }
    }



    internal class Program
    {
         
        static void Main(string[] args)
        {
            

            IAttackable[] attacker = new IAttackable[2];
            attacker[0] = new Knight("김검사", 10);
            attacker[1] = new Mage("이마법", 6);

            IDefendable[] defender = new IDefendable[1];
            defender[0] = new Knight("김검사", 10);

            foreach(IAttackable att in attacker)
            {
                att.Attack("고블린");
            }

            defender[0].Defend();
            
        }
    }
}