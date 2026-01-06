using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentHP = 80;
            int maxHP = 100;
            int monsterDamage = 25;
            int healHP = 30;
            int poisionDamage = 5;

            Console.WriteLine($"초기 체력: {currentHP}/{maxHP}");
            Console.WriteLine($"데미지 -{monsterDamage}: {currentHP -= monsterDamage}/{maxHP}");
            Console.WriteLine($"회복 +{healHP}: {currentHP += healHP}/{maxHP}");
            Console.WriteLine($"독 데미지 -{poisionDamage}: {currentHP -= poisionDamage}/{maxHP}");

            
            int experMonster = 150;
            int monsterKilled = 3;
            int experLevelUp = 500;

            Console.WriteLine($"\n처치한 몬스터: {monsterKilled}마리");
            Console.WriteLine($"획득 경험치: {experMonster * monsterKilled}");
            Console.WriteLine($"레벨업까지 필요: {experLevelUp - experMonster * monsterKilled}");


            int totalGold = 1234;
            int partyMembers = 5;

            Console.WriteLine($"\n총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}");
            Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드: {totalGold % partyMembers}");


            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHp = 60;
            int maxHp = 100;

            Console.WriteLine("\n=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건 ({requiredLevel} 이상): {playerLevel>=requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상): {currentHp >= maxHp/2}");
            Console.WriteLine($"입장 가능: {currentHp >= maxHp/2 && playerLevel >= requiredLevel}");


            int originalPrice = 5000;
            Console.Write("\nVIP 여부(소지한다면1, 아니라면2): ");
            string isVIP = Console.ReadLine();
            Console.Write("쿠폰 여부(소지한다면1, 아니라면2): ");
            string hasCoupon = Console.ReadLine();
            int intIsVIP = int.Parse(isVIP);
            int intHasCoupon = int.Parse(hasCoupon);
            double price = default;

            Console.WriteLine($"원가: {originalPrice}");

            if (intIsVIP == 1)
            {   
                price = originalPrice * 0.8;
                Console.WriteLine($"VIP 할인 (20%): {price}");
            }
            else {    
                price = originalPrice;
                Console.WriteLine($"VIP 할인 (0%): {price}");
            }

            if (intHasCoupon == 1)
            { 
                price = price - 500;
                Console.WriteLine($"쿠폰 할인 (-500): {price - 500}골드");
            }
            else {
                Console.WriteLine($"쿠폰 할인 (0): {price}골드");

            }

            Console.WriteLine($"할인된 가격: {price}");






            int a = 10;
            string b = a.ToString();

            Console.WriteLine(b);

            int c = int.Parse(b)+11;

            Console.WriteLine(c);

            Console.Write("2진수 입력: ");
            string d = Console.ReadLine();
            int e = Convert.ToInt32(d, 2);
            int f = e << 1;
            string g = Convert.ToString(f, 2);
            Console.WriteLine(g);
            Console.WriteLine(f);


        }
    }
}
