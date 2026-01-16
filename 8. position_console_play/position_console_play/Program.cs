using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace position_console_play
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            const int targetX = 100;
            const int targetY = 30;

            ConsoleKeyInfo keyinfo; //키 관련된 정보

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();    //화면 지우기
                Console.SetCursorPosition(x, y);    //좌표
                Console.Write("●"); //현재 위치 출력
                Console.SetCursorPosition(targetX, targetY);
                Console.Write("★");
                keyinfo = Console.ReadKey(true);    //키 입력 받기 (화면 출력 X)
                
                //방향키 입력에 따른 좌표 변경
                switch (keyinfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일"); break;
                    case ConsoleKey.Escape: break;  //ESC로 탈출
                }

                if (x == targetX && y == targetY)
                {
                    Console.Clear();
                    Console.WriteLine("집에 도착하셨습니다!");
                    break;
                }
            }


        }
    }
}