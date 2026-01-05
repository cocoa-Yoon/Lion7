using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.변수_선언과_동시에_초기화하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수 초기화
            int score = 100;    //정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5;   //실수형 "
            string city = "Seoul";  //문자열 "

            //임의로 끼워놓은 글자 or 숫자를 '리터럴'이라 명칭

            //변수 출력
            Console.WriteLine("점수: " + score);
            Console.WriteLine("온도: " + temperature);
            Console.WriteLine("도시: " + city);



            //방법1: 선언 후 할당 (두 줄)
            int health;
            health = 100;

            //방법2: 선언과 동시에 초기화(한 줄)
            int maxHealth = 100;
            int damage = 15;

            //게임로직 출력
            Console.WriteLine("체력 : " + health + "/" + maxHealth);

            //데미지를 받았습니다
            Console.WriteLine("데미지수치 : "+damage);
            


        }
    }
}
