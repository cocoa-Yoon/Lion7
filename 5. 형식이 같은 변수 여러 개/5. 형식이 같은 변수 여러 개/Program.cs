using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.형식이_같은_변수_여러_개
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////같은 데이터 타입의 변수를 쉼표로 구분해 한번에 선언
            //int x = 10, y = 20, z = 30; //정수형 x,y,z 선언하고 초기화

            //Console.WriteLine(x);   //출력 : 10
            //Console.WriteLine(y);   //출력 : 20
            //Console.WriteLine(z);   //출력 : 30


            //int age = 20;
            //int level = 10;
            //Console.WriteLine("나이 : {0}", age);

            //string name = "철수";
            //Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);

            //Console.WriteLine("나이 : " + age);

            //Console.WriteLine($"나이 : {age} 레벨 : {level}");

            ////수열느낌


            int posX = 0, posY = 50, posZ = 100;

            int red = 255, green = 128, blue = 0;

            Console.WriteLine("posX : {0}, posY : {1}, posZ : {2}", posX, posY, posZ);
            Console.WriteLine("posX : " + posX);
            Console.WriteLine($"posX : {posX} posY : {posY} posZ : {posZ}");

            Console.WriteLine("red : {0}, green : {1}, blue : {2}", red, green, blue);
            Console.WriteLine("red : " + red);
            Console.WriteLine($"red : {red} green : {green} blue : {blue}");


        }
    }
}
