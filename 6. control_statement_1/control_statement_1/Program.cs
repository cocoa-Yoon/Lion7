using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace control_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 조건문 //
            int number = 10;
            if (number > 15) Console.WriteLine("15보다 큽니다"); //한줄은 {} 생략 가능
            else Console.WriteLine("15보다 작거나 같습니다.");


            //int score = 75;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}
            //Console.WriteLine();

            //Console.WriteLine("플레이어 체력을 입력하시오: ");
            //int playerHealth = int.Parse(Console.ReadLine());
            //int maxHealth = 100;
            //int enemyDistnace = 5;
            //int attackRange = 3;

            //Console.WriteLine($"현재 체력: {playerHealth}/{maxHealth}");
            //if (playerHealth == 0)
            //{
            //    Console.WriteLine("게임 오버!");
            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //}
            //else if (playerHealth <= maxHealth * 0.3)
            //{
            //    Console.WriteLine("경고: 체력이 위험합니다!");
            //    Console.WriteLine("회복 아이템을 사용하세요!");
            //}
            //else if (playerHealth <= maxHealth * 0.5)
            //{
            //    Console.WriteLine($"체력이 50% 이하입니다.");
            //}
            //if (attackRange >= enemyDistnace)
            //{
            //    Console.WriteLine("적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}
            //Console.WriteLine();


            // switch문 //
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                default:
                    Console.WriteLine("유효하지 않은 요일");
                    break;
            }

            //Console.WriteLine("1. warrior, 2. mage, 3. archer 4. thief");
            //Console.Write("select the number of job: ");
            //int jobchoice = int.Parse(Console.ReadLine());
            //Console.WriteLine("=== character create ===");

            //switch (jobchoice)
            //{
            //    case 1:
            //        Console.WriteLine("job: warrior\ntrait: strong power");
            //        Console.WriteLine("main weapon: sword\nstats: HP +50, str +10");
            //        break;
            //    case 2:
            //        Console.WriteLine("job: mage\ntrait: various magic");
            //        Console.WriteLine("main weapon: cane\nstats: MP +100 int +10");
            //        break;
            //    case 3:
            //        Console.WriteLine("job: archer\ntrait: long range");
            //        Console.WriteLine("main weapon: bow\nstats: HP +10, dex +10");
            //        break;
            //    case 4:
            //        Console.WriteLine("job: theif\ntrait: fast move");
            //        Console.WriteLine("main weapon: dagger\nstats: HP +30 luck +10");
            //        break;
            //}
            //Console.WriteLine();


            // for문 //
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"number: {i}");
            }

            //Console.Write("몬스터 수 입력: ");
            //int monsterCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("=== 몬스터 웨이브 시작 ===");
            //for(int i = 1; i <= monsterCount; i++)
            //{
            //    Console.WriteLine($"고블린 #{i} 생성");
            //}
            //Console.WriteLine($"총 {monsterCount}마리 생성 완료\n");

            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //for(int i = 5; i >0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}
            //Console.WriteLine("게임시작!");

            //for(; ; )
            //{
            //    Console.WriteLine("무한반복");
            //    Thread.Sleep(1000);
            //}


            // 랜덤함수 //
            Random random = new Random();   //랜덤함수 사용방법
            int num = random.Next(1, 7);

            //Console.WriteLine("당신은 20번 뽑기가 가능합니다. 지금 실행합니다.");
            //Random rand = new Random();
            //int randomNumber = 0;

            //for(int i = 1; i < 21; i++)
            //{
            //    randomNumber = rand.Next(1, 101);
            //    if (randomNumber <= 10)
            //    {
            //        Console.WriteLine("무한의 대검");
            //        Thread.Sleep(1000);
            //    }
            //    else if (randomNumber <= 30)
            //    {
            //        Console.WriteLine("광명검");
            //        Thread.Sleep(1000);
            //    }
            //    else if (randomNumber <= 60)
            //    {
            //        Console.WriteLine("일살");
            //        Thread.Sleep(1000);
            //    }
            //    else
            //    {
            //        Console.WriteLine("목검");
            //        Thread.Sleep(1000);
            //    }
            //} 




        }
    }
}
