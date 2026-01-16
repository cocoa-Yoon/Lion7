using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 : 효율적 //
            int[] scores = new int[5];  //5개의 사물함
            scores[0] = 1;
            scores[1] = 2;
            scores[2] = 3;
            scores[3] = 4;
            scores[4] = 5;
            // scores[5] = 6; : Error(out of range)

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            int[] values = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                Console.Write(scores[i] + "  ");
            }


            string[] inven = new string[5];
            inven[0] = "회복 포션";
            inven[1] = "마나포션";
            inven[2] = "강철 검";
            inven[3] = "가죽 갑옷";
            inven[4] = "마법 반지";

            Console.WriteLine("\n\n=== 인벤토리 ===");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"인벤토리{i + 1} : {inven[i]}");
            }
            Console.WriteLine("");


            string[] item = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"item {i + 1} : ");
                item[i] = Console.ReadLine();
            }
            Console.WriteLine("=== item ===");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"item{i + 1} : {item[i]}");
            }
            Console.WriteLine("");



            int[] score = { 71, 84, 92, 87, 90 };

            Console.WriteLine ("총 인원 : "+ score.Length);
            int max = 0;
            int min = 100;


            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= max)
                {
                    max = score[i];
                }

                if (score[i] <= min)
                {
                    min = score[i];
                }
            }

            Console.WriteLine($"max score = {max}, min score = {min}");


            // 정렬 //

            int[] sortedScores = (int[]) score.Clone();     //복사본 생성
            
            Array.Sort(sortedScores);   //오름차순
            
            for (int i = 0; i < sortedScores.Length; i++)
            {
                Console.WriteLine(sortedScores[i]);
            }

            Array.Reverse(sortedScores);    //내림차순
            for (int i = 0; i < sortedScores.Length; i++)
            {
                Console.WriteLine(sortedScores[i]);
            }

            int searchScore = 71;
            int index = Array.IndexOf(score, searchScore);
            Console.WriteLine($"{searchScore}점의 위치: 인데스 {index}");
            Console.WriteLine("찾은값 : " + score[index]);

        }
    }
}
