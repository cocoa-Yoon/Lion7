using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fucntion
{
    internal class Program
    {
        //// 1단계 기본함수 //

        //static void SayHello()
        //{
        //    Console.WriteLine("Hello, warrior.");
        //    Console.WriteLine("Start adventure.");
        //}

        //static void ShowGameStart()
        //{
        //    Console.WriteLine("Game Start!");
        //}

        //static void PrintSeparator()
        //{
        //    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        //}


        //static void Main(string[] args)
        //{
        //    ShowGameStart();
        //    Console.WriteLine();

        //    SayHello();
        //    PrintSeparator();

        //    Console.WriteLine("finding game menu");
        //    PrintSeparator();
        //}


        //// 2단계 매개변수 입력 //
        //static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        //{
        //    Console.WriteLine($"파이어볼 시전!");
        //    Console.WriteLine($"대상 : {target}");
        //    Console.WriteLine($"데미지 : {damage}");
        //    Console.WriteLine($"마나 소모 : {manaCost}\n");
        //}

        //static void Main(string[] args)
        //{
        //    CastFireBall("고블린", 150, 40);
        //    CastFireBall("고블린", manaCost: 40);
        //    CastFireBall("고블린", 20);
        //}



        //// 반환 값이 있는 함수 //
        //static int GetNumber() //정수반환
        //{
        //    return 42;
        //}

        //static string ConnectMessage (string name)
        //{
        //    return "welcome! " + name + " glad to see you again";
        //}


        //static void Main(string[] args)
        //{
        //    int num = GetNumber();

        //    Console.WriteLine("return number : " + num);

        //    string cm = ConnectMessage("홍길동");

        //    Console.WriteLine(cm);
        //}


        //// ref //
        //static void Attack(ref int a)
        //{
        //    Console.WriteLine("공격력 : " + a);
        //    a++;
        //}

        //static void Main(string[] args) 
        //{
        //    int a = 10;
        //    Attack(ref a);      //함수에서 바뀐 변수 자동 반환(return)
        //    Console.WriteLine("a 값 : " + a);
        //}


        //// out //
        //static void Attack(int a, int d, out int attack, out int defense)
        //{
        //    attack = a;
        //    defense = d;
            
        //    attack++;
        //    defense++;
        //}

        //static void Main(string[] args)
        //{
           
        //    Attack(10, 20, out int attack, out int defense);

        //    Console.WriteLine("공격력 : " + attack);
        //    Console.WriteLine("방어력 : " + defense);

        //}


        // 재귀함수 : 자기 자신을 호출 //

        static int SumToN(int n)
        {
            if (n<=0) return 0;

            return n + SumToN(n - 1);   //n+ (n-1까지의 합)
        }


        static void Main(string[] args)
        {
            int sum = SumToN(10);

            Console.WriteLine($"1 + 2 + ... + 10 = {sum}");
        }

    }
}
