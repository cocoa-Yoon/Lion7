using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integerNum = 10;    //정수 데이터
            float floatNum = 3.14f; //단정밀도 실수
            double doubleNum = 3.14159;     //배정밀도 실수


            Console.WriteLine(integerNum);   //출력: 10
            Console.WriteLine(floatNum);     //출력: 3.14
            Console.WriteLine(doubleNum);    //출력 : 3.14159

            byte level = 50;
            short attack = 1500;
            int gold = 123456789;
            long experience = 99999999999L;

            Console.WriteLine("=== 케릭터 정보 ===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"시작 골드: {gold}");
            Console.WriteLine($"경험치: {experience}");

            Console.WriteLine($"byte 최댓값: {byte.MaxValue}");
            Console.WriteLine($"short 최댓값: {short.MaxValue}");
            Console.WriteLine($"int 최댓값: {int.MaxValue:N0}");
            Console.WriteLine($"long 최댓값: {long.MaxValue:N0}");


            //실수 데이터 형식: 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f;  //단정밀도 실수
            double doublePrecision = 3.1415926535;  //배정밀도 실수
            decimal highPrescision = 3.1415926535897932384626433833m;   //고정밀도 실수

            Console.WriteLine(singlePrecision);
            Console.WriteLine(doublePrecision);
            Console.WriteLine(highPrescision);


            //접미사 사용: 숫자의 데이터 형식을 명시
            int integerValue = 100; //기본 정수형
            long longValue = 100L;  //정수형
            float floatValue = 3.14f;   //실수형
            double doubleValue = 3.14;  //기본 실수형
            decimal decimalValue = 3.14m;   //고정밀도 실수형

            Console.WriteLine(integerValue);
            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);

        }
    }
}
