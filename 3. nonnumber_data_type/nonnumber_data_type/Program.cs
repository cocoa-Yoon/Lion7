using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonnumber_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char 형식: 단일 문자를 표현 //
            char letter = 'A';  //문자 'A' 저장
            char symbol = '#';  //특수 기호 저장
            char number = '9';  //숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

            Console.WriteLine(letter);
            Console.WriteLine(symbol);
            Console.WriteLine(number+"\n");

            //float move_speed = 5.5f;
            //double attack_speed = 1.25;
            //decimal item_price = 12.00m;

            //Console.WriteLine("=== 케릭터 능력치 ===");
            //Console.WriteLine($"이동속도 {move_speed}");
            //Console.WriteLine($"공격속도 {attack_speed}");
            //Console.WriteLine($"아이템 가격 {item_price}");


            // string 형식: 여러 문자를 저장 //
            string greeting = "Hello, World!";
            string name = "Alice";

            Console.WriteLine(greeting);
            Console.WriteLine(name + "\n");

            //char grade = 'A', symbol = '★', number = '9';
            //string playerName = "홍길동", welcomeMessage = "게임에 오신 것을 환옇합니다!", emptyString = "";

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}");
            //Console.WriteLine(welcomeMessage);


            // bool 형식: 참(True) 또는 거짓(False) //
            bool isRunning = true;      //1
            bool isFinished = false;    //0

            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished + "\n");

            //bool TRUE = true;
            //bool FALSE = false;

            //Console.WriteLine("\n=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {TRUE}");
            //Console.WriteLine($"일시정지: {FALSE}");
            //Console.WriteLine($"열쇠 소지: {FALSE}");
            //Console.WriteLine($"문 열림: {FALSE}");
            //Console.WriteLine($"플레이어 생존: {TRUE}");
            //Console.WriteLine("\n=== 케릭터 상태 ===");
            //Console.WriteLine($"체력: 80");
            //Console.WriteLine($"건강 상태: {TRUE}");
            //Console.WriteLine($"위험 상태: {FALSE}");


            // 닷넷 형식: 기본 형식의 닷넷 표현 //
            System.Int32 number0 = 1234; //int의 닷넷 형식
            System.String text0 = "Hello";
            System.Boolean flag0 = true;

            Console.WriteLine(number0);
            Console.WriteLine(text0);
            Console.WriteLine(flag0 + "\n");


            // int 래퍼 형식의 메서드 활용 //
            int number1 = 123;
            string number1AsString = number1.ToString();

            // bool 래퍼 형식의 메서드 활용 //
            bool flag1 = true;
            string flag1AsString = flag1.ToString();

            Console.WriteLine(number1AsString);
            Console.WriteLine(flag1AsString + "\n");


        }
    }
}
