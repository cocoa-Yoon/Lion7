using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_data_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 사용자 입력을 문자열로 받기 //
            Console.Write("이름을 입력하세요: ");
            string userName = Console.ReadLine();   //사용자로부터 입력 받기

            Console.WriteLine($"안녕하세요, {userName}님!\n");  //입력값 출력


            // 문자열을 정수로 변환 //
            Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);   //문자열 정수 변환

            Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!\n");


            // 이진수를 정수로 변환 //
            Console.Write("2진수 입력: ");
            string binaryInput = Console.ReadLine();
            int deciamlValue = Convert.ToInt32(binaryInput, 2);  //2진수 -> 10진수 변환

            // 정수를 이진수로 변환 //
            string binaryOutput = Convert.ToString(deciamlValue, 2);    //10진수 -> 2진수 변환

            Console.WriteLine($"입력한 이진수: {binaryInput}");
            Console.WriteLine($"10진수로 변환: {deciamlValue}");
            Console.WriteLine($"다시 이진수로 변환: {binaryOutput}\n");


            Console.WriteLine("=== 케릭터 생성 ===");
            Console.Write("캐릭터 이름을 입력하세요: ");
            string name = Console.ReadLine();
            Console.WriteLine($"환영합니다, {name}님!");

            Console.Write("시작 레벨을 입력하세요: ");
            string level = Console.ReadLine();
            int levelNum = int.Parse(level);
            Console.WriteLine($"{name}님의 시작 레벨은 {levelNum}입니다.\n");


            // var를 사용한 변수 선언 //
            var playerName = "Alice";
            var playerAge = "25";
            var isStudent = true;

            Console.WriteLine($"이름: {playerName}, 나이: {playerAge}, 학생 여부: {isStudent}");


            // default 키워드를 사용한 기본 설정 //
            int defaultInt = default;   //0
            string defaultString = default;  //null
            bool defaultBool = default;  //false

            Console.WriteLine($"정수 기본값: {defaultInt}");
            Console.WriteLine($"문자열 기본값: {defaultString}");
            Console.WriteLine($"논리값 기본값: {defaultBool}");


            // 1. 암시적 변환 (작은 타입 -> 큰 타입) //
            int smallNumber = 100;
            long bigNumber = smallNumber; //int ->long(자동 변환)
            double doubleNumer = smallNumber; //int -> double(자동 변환)


            Console.WriteLine("\n=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber.GetType()}");
            Console.WriteLine($"long: {bigNumber.GetType()}");
            Console.WriteLine($"double: {doubleNumer.GetType()}");

            // 2.명시적 변환 (큰타입 ->작은타입) //
            double pi = 3.14159;
            int intPi = (int)pi;  //소수점을 버림!(명시적 변환 필요)

            Console.WriteLine("\n=== 명시적 변환 ===");
            Console.WriteLine($"double : {pi}");
            Console.WriteLine($"int로 변환 : {intPi}"); //3.14... 

            // 3. 문자열을 숫자로 변환 //
            string scoreText = "95";
            int score = int.Parse(scoreText);

            string priceText = "19.99";
            double price = double.Parse(priceText);

            Console.WriteLine("\n=== 문자열 변환 ====");
            Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자: {score}");
            Console.WriteLine($"가격(문자열) : {priceText} -> 숫자: {price}");

            // 4. 숫자를 문자열로 변환 //
            int playerLevel = 50;
            string levelText = playerLevel.ToString();

            Console.WriteLine("\n=== 숫자를 문자열로 ===");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열: {levelText}");

            ////형식 변환 주의사항 //
            //double value = 9.8;
            //int result = (int)value;  // 9.8 → 9 (소수점 버려짐!)

            //int bigValue = 300;
            //byte smallValue = (byte)bigValue;  // 오버플로우 발생!

            //string text = "abc";
            //// int num = int.Parse(text);  // ❌ 런타임 오류!

            //// 안전한 변환: TryParse 사용 //
            //if (int.TryParse(text, out int num))
            //{
            //    Console.WriteLine($"변환 성공: {num}");
            //}
            //else
            //{
            //    Console.WriteLine("변환 실패!");
            //}

        }
    }
}
