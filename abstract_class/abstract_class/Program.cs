using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public abstract class Character     //추상클래스 상속 자녀는 모든 메서드를 상속받아서 반드시 구현
    {
        public int hp;
        public abstract void Job();
    }

    public class Mage : Character
    {
        public override void Job()
        {
            Console.WriteLine("직업 : 마법사");
        }
    }

    public class Archer : Character
    {
        public override void Job()
        {
            Console.WriteLine("직업 : 궁수");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Character[] ch = { new Mage(), new Archer() };
            
            Character mage = new Mage();  //추상클래스는 객체생성 못함 Character ch = new Character (X)
            Character archer = new Archer();

            for(int i = 0; i < ch.Length; i ++ )
            {
                ch[i].Job();
            }

            foreach(Character c in ch)
            {
                c.Job();
            }



        }
    }
}
