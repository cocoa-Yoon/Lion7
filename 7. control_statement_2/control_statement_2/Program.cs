using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_statement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while //
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();

            //int sum = 0, plus = 1;

            //while (plus < 6)
            //{
            //    sum += plus;
            //    Console.WriteLine(sum);
            //    plus++;
            //}


            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //Console.WriteLine("=== 목표 달성하기 ===");
            //while (coins < target)
            //{
            //    coins += 10;
            //    day++;
            //    Console.WriteLine($"{day}일차: 코인 {coins}개");
            //}
            //Console.WriteLine($"??목표 달성 ! {day}일 걸렸습니다!");


            // do-while //
            int x = 5;
            do
            {
                Console.WriteLine("최소 한번 실행됩니다.");
                x--;
            } while (x > 0);
            Console.WriteLine();

            //int totalPrice = 0;
            //string choice;
            //Console.WriteLine("=== 메뉴판 ===");
            //Console.WriteLine("1. 짜장면 - 5000원");
            //Console.WriteLine("2. 짬뽕 - 6000원");
            //Console.WriteLine("3. 탕수육 - 15000원");
            //Console.WriteLine("4. 볶음밥 - 6000원");

            //do
            //{
            //    Console.Write("\n메뉴를 선택하십시오(0. 주문 종료) : ");
            //    choice = Console.ReadLine();
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 주문완료");
            //            totalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짜장면 주문완료");
            //            totalPrice += 6000;
            //            break;
            //        case "3":
            //            Console.WriteLine("탕수육 주문완료");
            //            totalPrice += 15000;
            //            break;
            //        case "4":
            //            Console.WriteLine("볶음밥 주문완료");
            //            totalPrice += 6000;
            //            break;
            //        case "0":
            //            Console.WriteLine("주문 종료");
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 선택입니다.");
            //            break;
            //    }

            //    Console.WriteLine($"총 가격 : {totalPrice}");
            //} while (choice != "0");


            // break, continue, goto //
            for (int y = 0; y <= 10; y++)
            {
                if (y == 5)
                    continue;    //break: 반복문 종료, continue: 현재 반복을 건너뛰고 다음 반복으로 넘어감
                Console.WriteLine(y);
            }
            Console.WriteLine();


            int n = 1;
        광마회귀:
            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;
                if (n == 3)
                {
                    goto 일양현스폰;
                }
                goto 광마회귀;  //레이블로 이동(신중히 사용할 것)              
            }
        일양현스폰:
            Console.WriteLine("일양현에 망나니 부활!\n");


            for (int p = 1; p <= 3; p++)
            {
                for (int q = 1; q <= 3; q++)
                {
                    Console.WriteLine($"p = {p}, q = {q}");
                }
                Console.WriteLine();
            }


            for (int A = 0; A <= 4; A++)
            {
                for (int B = 0; B <= A; B++)
                {              
                        Console.Write($"☆");                 
                }
                Console.WriteLine("");
            }
             
        }
    }
}
