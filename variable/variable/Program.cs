using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////변수 선언: 데이터 타입과 변수 이름을 지정
            
            int age;
            age = 25;

            Console.WriteLine(age + "\n");


            ////리터럴: 코드에서 고정된 값을 의미
            int number = 10;
            double pi = 3.14;
            char letter = 'A';
            string name = "Alice";

            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(letter);
            Console.WriteLine(name + "\n");


            ////변수 선언 후 값 저장
            string greeting;
            greeting = "Hello, World!";

            Console.WriteLine(greeting + "\n");


            ////변수 선언과 동시에 초기화
            int score = 100;
            double temperature = 36.5;
            string city = "Seoul";

            Console.WriteLine(score);
            Console.WriteLine(temperature);
            Console.WriteLine(city + "\n");


            ////형식이 같은 변수 여러 개를 한 번에 선언
            int x=11, y=12, z=13;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z + "\n");


            ////상수 사용
            const double PI = 3.14159;
            const int MAX_SCORE = 100;

            Console.WriteLine("Pi: " + PI);
            Console.WriteLine("Max Score: " + MAX_SCORE + "\n");
            
        }
    }
}
