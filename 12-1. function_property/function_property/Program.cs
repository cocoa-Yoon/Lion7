using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace function_property
{
    class Character
    {
        private int att;
        public int Att
        {
            get { return att; }

            set
            {
                att = value;
            }
        }


        //    public int Att { get; set; }    //자동 프로퍼티

        //    public int MaxHp { get; private set; }  //읽기 전용
        //}

        //class Player
        //{
        //    private string name;
        //    private int gold;

        //    public string Name { get { return name; } set { name = value; } }
        //    public int Gold
        //    {
        //        get { return gold; }

        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("골드가 부족합니다.");
        //            }
        //            else
        //            {
        //                gold = value;
        //            }
        //        }
        //    }
        //}

    }

    class Student
    {
        private string name;
        private int score;

        public string Name
        {
            get { return name; }
        }
        public int Score
        {
            get { return score; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"점수는 0~100사이여야 합니다.(입력값 : {value})");
                    score = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine($"점수는 0~100사이어야 합니다. (입력값: {value})");
                    score = 100;
                }
                else
                {
                    score = value;
                }
            }
        }


        public string Grade
        {
            get
            {
                if (score >= 90)
                    return "A";
                else if (score >= 80)
                    return "B";
                else if (score >= 70)
                    return "C";
                else if (score >= 60)
                    return "D";
                else
                    return "F";
            }
        }
        public Student(string studentName)
        {
            name = studentName;
            score = 0;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"점수: {Score}점");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Character c = new Character();

            //c.Att = 5;

            //Console.WriteLine("공격력 : " +  c.Att);


            //Player player = new Player();
            //player.Name = "홍길동";
            //player.Gold = -100;

            //Console.WriteLine($"이름 : {player.Name}");
            //Console.WriteLine($"골드 : {player.Gold}");

            Student student = new Student("홍길동");

            student.Score = 95;
            student.ShowInfo();

            Console.WriteLine();

            student.Score = 75;
            student.ShowInfo();

            Console.WriteLine();

            // 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();



        }
    }
}
