using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace various_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 다차원 배열 //
            //int[,] array = new int[3, 4];

            //int totalElements = array.Length;   //12 (3 x 4) : 전체 요소 개수

            //int rows = array.GetLength(0);  //3 (행 개수)
            //int cols = array.GetLength(1);  //4 (열 개수)

            //int dimensions = array.Rank;    //2 : 배열의 차원 수

            //string[,] seats = new string[3, 3] {
            //    { "A1", "A2", "A3" },
            //    { "B1", "B2", "B3" },
            //    { "C1", "C2", "C3" }
            // };


            //for (int i = 0; i < seats.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seats.GetLength(1); j++)
            //    {
            //        Console.Write($"[{seats[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine($"첫번째 좌석 : {seats[0, 0]}");
            //Console.WriteLine($"중앙 좌석 : {seats[1, 1]}");
            //Console.WriteLine($"마지막 좌석 : {seats[2, 2]}");


            //string[] subject = new string[4] {"국어", "영어", "수학", "과학"};
            //string[] name = new string[3] { "김철수", "이영희", "박민수" };
            //int[,] subjectScore = new int[3, 4]
            //{
            //    {85, 90, 88, 92 },
            //    {78, 85, 90, 87 },
            //    {92, 88, 95, 90 }
            //};
            //double sum = 0;
            //double averageSum = 0;

            //Console.Write("=== 성적표 ===\n이름   ");
            //for(int i = 0;i < subject.Length; i++)
            //{
            //    Console.Write(subject[i]+"   ");
            //}
            //Console.WriteLine("평균");
            //Console.WriteLine("--------------------------------------");
            //for(int i = 0; i < name.Length; i++)
            //{
            //    Console.Write(name[i]+"   ");
            //    for (int j  = 0; j < subject.Length; j++)
            //    {
            //        Console.Write($"{subjectScore[i, j]}    ");
            //        sum += subjectScore[i, j];
            //    }
            //    double average = (double)sum / subject.GetLength(0);
            //    Console.WriteLine($"{average:F1}");
            //    sum = 0;
            //}

            //Console.WriteLine("=== 과목별 평균 ===");
            //for (int i = 0; i < subject.Length; i++)
            //{
            //    for (int j = 0; j < name.Length; j++)
            //    {
            //        averageSum += subjectScore[j, i];
            //    }
            //    double subjectAverage = (double)averageSum / name.GetLength (0);
            //    Console.WriteLine($"{subject[i]}: {subjectAverage:F1}점");
            //    averageSum = 0;
            //}


            //// 가변 배열 //
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };    //4명
            //raid[1] = new string[] { "도적", "전사", "힐러" };              //3명
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사" , "도적" };  //5명


            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for (int i = 0; i < 3; i++)
            //{
            //    foreach (string member in raid[i])
            //    {
            //        Console.Write(member+" ");
            //    }
            //    Console.WriteLine();
            //}


            //// 동적 배열 //
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트            
            //List<int> scores = new List<int> { 85, 90, 78, 95 };    // 초기값과 함께 선언 List<string> item = new List<string> { "검", "방패", "포션" };

            //var players = new List<string> { "철수", "영희", "민수" };    // C# 3.0 이후 간단한 초기화

            //List<string> items = new List<string>();
            //items.Add("회복 포션"); // Add: 끝에 추가
            //items.Add("마나 포션");


            //List<string> inventory = new List<string>();

            //Console.WriteLine("\n=== 인벤토리 ===");

            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 3개 추가");

            //int index = 1;
            //Console.WriteLine($"\n인벤토리 ({inventory.Count})개");
            //foreach(string item in inventory)
            //{
            //    Console.WriteLine($"{index}. {item}");
            //    index++;
            //}
            //inventory[0] = "초록포션";

            //index = 1;
            //Console.WriteLine($"\n인벤토리 ({inventory.Count})개");
            //foreach (string item in inventory)
            //{
            //    Console.WriteLine($"{index}. {item}");
            //    index++;
            //}

            //inventory.Insert(1, "전설 검");    //특정위치에 추가
            //index = 1;
            //Console.WriteLine($"\n인벤토리 ({inventory.Count})개");
            //foreach (string item in inventory)
            //{
            //    Console.WriteLine($"{index}. {item}");
            //    index++;
            //}

            //inventory.Remove("초록포션");    //아이템 제거
            //inventory.RemoveAt(2);          //인데스로 제거
            //index = 1;
            //Console.WriteLine($"\n인벤토리 ({inventory.Count})개");
            //foreach (string item in inventory)
            //{
            //    Console.WriteLine($"{index}. {item}");
            //    index++;
            //}


            //Dictionary<string,int> stats = new Dictionary<string,int>();

            //stats.Add("HP", 100);
            //stats.Add("MP", 100);
            //stats.Add("AD", 10);
            //stats.Add("AP", 5);

            //Console.WriteLine("=== 케릭터 스탯 ===");

            //foreach(KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}:{stat.Value}");
            //}

            //string searchStat = "AD";
            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(searchStat);
            //}
            //else Console.WriteLine("no stat find");


            string storeInput = "";
            int currentMoney = 2000;

            Dictionary<string, int> storeItem = new Dictionary<string, int>
            {
                {"회복 포션", 50 },
                {"마나 포션", 40 },
                {"강철 검", 500 },
                {"가죽 갑옷", 300 },
                {"마법 반지", 1000 }
            };

            foreach (var item in storeItem)
            {
                Console.WriteLine($"{item.Key} : {item.Value}골드");
            }

            do
            {
                Console.Write("구매하실 물건을 입력하십시오.(구매 종료 : X) : ");
                storeInput = Console.ReadLine();

                if (storeItem.ContainsKey(storeInput))
                {
                    int itemPrice = storeItem[storeInput];
                    if (currentMoney >= itemPrice)
                    {
                        currentMoney -= itemPrice;
                        Console.WriteLine($"'{storeInput}' 구매 성공!");
                        Console.WriteLine($"남은 골드 : {currentMoney}");
                    }
                    else if (currentMoney < itemPrice)
                    {
                        Console.WriteLine($"골드가 부족합니다. 현재 골드 : {currentMoney}");
                    }
                    
                }
                else if (storeInput == "x")
                {
                    Console.WriteLine("구매 종료");
                }
                else Console.WriteLine("잘못 입력하셨습니다.");
            } while (storeInput != "x");

        }
    }
}
