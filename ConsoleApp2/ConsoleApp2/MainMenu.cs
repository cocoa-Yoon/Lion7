using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    public class MainMenu
    {
        Player player;
        Monster monster;
        Field field;

        public MainMenu(Player p)
        {
            player = p;
            monster = new Monster();
            field = new Field(player, monster);
        }

        public void MainProgress()
        {
            while (true)
            {
                Console.Clear();
                player.ShowInfo();

                Console.WriteLine("\n1. 사냥  2. 상점  3. 종료");
                Console.Write("번호 선택 : ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    while (true)
                    {
                        monster.SelectMonster();
                        bool result = field.Fight();

                        if (!result)
                            continue;

                        Console.WriteLine("\n계속 사냥하시겠습니까? (1. 예 2. 아니오)");
                        int next = int.Parse(Console.ReadLine());
                        if (next == 2)
                            break;
                    }
                }
                else if (input == 2)
                {
                    Shop.Enter(player);
                }
                else if (input == 3)
                {
                    Console.WriteLine("게임 종료");
                    break;
                }
            }
        }
    }
}
