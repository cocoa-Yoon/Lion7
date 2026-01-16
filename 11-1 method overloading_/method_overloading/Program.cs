using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    internal class Program
    {
        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지 : 10");
        }

        static void Attack(string target)   //같은 이름이어도 매개 변수를 통해 인식
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine("데미지 : 10");
        }

        static void Attack(string skillName, string target, int damage)   
        {
            Console.WriteLine($"스킬 발동 : {skillName}");
            Console.WriteLine($"{target}에게 {damage} 데미지!");
        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Attack();
            Console.WriteLine();
            Attack("몬스터");
            Console.WriteLine();
            Attack("파이어볼", "몬스터", 15);

        }
    }
}
