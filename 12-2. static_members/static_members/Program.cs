using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_members
{
    class Character
    {
        public static int totalCount = 0;   //static : 모든 캐릭터가 공유
        public static string GameVersion { get; set; } = "1.0.0";

        public string name;                 //일반 : 각 캐릭터마다 다름

        public void AddCount()
        {
            totalCount++;
        }
    }

    class Skill 
        { 
   
 
        private string name;
        private int att;
        public Skill()
        {

        }

        public Skill(string name, int att)
        {
            this.name = name;
            this.att = att;
        }

        public void SkillStart()
        {
            Console.WriteLine("스킬 이름 : " +  name);
            Console.WriteLine("스킬 데미지 : " + att);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            Character c2 = new Character();

            c1.name = "전사";
            c2.name = "마법사";

            Character.totalCount = 1;

            Console.WriteLine(c1.name);
            Console.WriteLine(c2.name);

            Console.WriteLine("카운트 : " + Character.totalCount);
            
            c1.AddCount();
            c2.AddCount();

            Console.WriteLine("카운트 : " + Character.totalCount);

            Skill s = new Skill("블리자드", 1000000);
            s.SkillStart();

        }
    }
}
