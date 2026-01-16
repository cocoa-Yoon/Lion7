using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 연산자 //
            int a = 5, b = 3;
            int sum = a + b;
            bool isEqual = (a == b);

            Console.WriteLine($"합: {sum}");
            Console.WriteLine($"a와 b가 같은가? {isEqual}");


            // 단항 연산자 //
            int number = 5;
            Console.WriteLine("\n" + +number);
            Console.WriteLine(-number);

            bool flag = true;
            Console.WriteLine(!flag);   //논리 부정
            Console.WriteLine();


            // 산술 연산자 //
            int c = 10, d = 3;
            Console.WriteLine("\n"+ (c + d));
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);   //나눗셈
            Console.WriteLine(c % d);   //나머지

            string firstName = "Alice";
            string lastName = "Smith";
            Console.WriteLine("\n" + firstName + " " +  lastName);


            // 할당 연산자 //
            //a = a + b;   ==   a += b;
            int x = 10, y = 3;
            x += y; //x = x + 5
            Console.WriteLine($"\n합계: {x}");
            x = 10;
            x -= y;
            Console.WriteLine($"합계: {x}");
            x = 10;
            x *= y;
            Console.WriteLine($"합계: {x}");
            x = 10;
            x /= y;
            Console.WriteLine($"합계: {x}");
            x = 10;
            x %= y;
            Console.WriteLine($"합계: {x}\n");


            // 증감 연산자 //
            int k = 3;
            k++;    //후위 증감은 값 사용 후 증감 적용
            Console.WriteLine(k);   
            Console.WriteLine(--k + "\n"); //전위 증감은 증감 적용 후 값 사용


            // 관계형 연산자 //
            int m = 4, n = 5;
            Console.WriteLine(m < n);
            Console.WriteLine(m == n);
            Console.WriteLine(m != n);
            Console.WriteLine();


            // 논리 연산자 //
            bool p = true, q = false;
            Console.WriteLine(p && q);  //AND
            Console.WriteLine(p || q);  //OR
            Console.WriteLine(!p);      //NOT
            Console.WriteLine();


            // 비트 연산자 (연산속도 빠름) // 
            int e = 5;  //0101
            int f = 3;  //0011
            Console.WriteLine(e&f); //AND: 1(0001)
            Console.WriteLine(e|f); //OR: 7(0111)
            Console.WriteLine(e^f); //XOR: 6(0110)
            Console.WriteLine(~e);  //NOT: -6

            string binary = Convert.ToString(e | f, 2);
            Console.WriteLine(binary.PadLeft(4,'0'));
            Console.WriteLine();

            // 시프트 연산자 //
            int value = 4;  //0100
            Console.WriteLine(value << 1);  //왼쪽 이동: 8 (1000)
            Console.WriteLine(value >> 1);  //오른쪽 이동: 2 (0010)


            // 기타 연산자 //
            int g = 10, h = 20;
            int max = (g > h) ? g : h;  //조건문 참일 때 g 거짓일 때 h / 둘중 큰값이 입력
            Console.WriteLine(max);

            int playerLevel = 45;
            string playerGrade = (playerLevel >= 50) ? "고급" :
                           (playerLevel >= 30) ? "중급" : "초급";
            Console.WriteLine("\n=== 플레이어 등급 ===");
            Console.WriteLine(playerGrade);


            // 연산자 우선순위 //
            int result = 10 + 2 * 5;    //곱셈이 덧셈보다 우선
            Console.WriteLine(result);

            int adjustResult = (10 + 2) * 5;    //괄호로 우선순위 변경
            Console.WriteLine(adjustResult);

            int baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0
        }
    }
}
