using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace console_shoting_game
{
    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        public int playerX;
        public int playerY;

        public Bullet[] playerBullet = new Bullet[20];  //20개를 먼저 생성 후 준비된 미사일을 활용 유니티로 오브젝트 풀
        public Bullet[] playerBullet2 = new Bullet[20];
        public Bullet[] playerBullet3 = new Bullet[20];
        public int score = 100;

        public Item item = new Item();
        public int itemCount = 0;

        public Player() //생성자
        {
            playerX = 0;
            playerY = 12;

            for(int i = 0; i < 20; i++)
            {
                playerBullet[i] = new Bullet();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new Bullet(); //객체생성
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new Bullet (); //객체생성
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
        } 

        public void GameMain()
        {
            KeyControl();
            PlayerDraw();
            UIscore();

            if(item.itemLife)
            {
                item.ItemDraw();
                CrashItem();
            }
        }

        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2 && playerX <= item.itemX + 2)
                {
                    item.itemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 20; i++) //총알 20개 초기화
                    {
                        playerBullet[i] = new Bullet(); //객체생성
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new Bullet(); //객체생성
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new Bullet(); //객체생성
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;



                    }

                }
            }
        }

        public void KeyControl()
        {
            int pressKey;

            if (Console.KeyAvailable)
            {
                pressKey = _getch();

                switch (pressKey)
                {
                    case 75:
                        playerX--;
                        if (playerX < 0) playerX = 0;
                        break;
                    case 72:
                        playerY--;
                        if (playerY < 0) playerY = 0;
                        break;
                    case 77:
                        playerX++;
                        if (playerX > 75) playerX = 75;
                        break;
                    case 80:
                        playerY++;
                        if (playerY > 21) playerY = 21;
                        break;
                    case 32:
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY + 1;
                                break;
                            }
                        }
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 1;
                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void BulletDraw()
        {
            string bullet = "->";

            for (int i = 0;i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);

                    Console.Write(bullet);
                    playerBullet[i].x++;

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);

                    Console.Write(bullet);
                    playerBullet2[i].x++;

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet3[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);

                    Console.Write(bullet);
                    playerBullet3[i].x++;

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };
            for(int i=0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }

        }

        public void UIscore() 
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //충돌 처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire  == true)
                {
                    if(playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x <= enemy.enemyX+1
                            && playerBullet[i].x >= enemy.enemyX-1) //충돌
                        {
                            item.itemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;
                            
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false;

                            score += 100;
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet2[i].fire == true)
                {
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        if (playerBullet2[i].x <= enemy.enemyX + 1
                            && playerBullet2[i].x >= enemy.enemyX - 1) //충돌
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false;

                            score += 100;
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x <= enemy.enemyX + 1
                            && playerBullet[i].x >= enemy.enemyX - 1) //충돌
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false;

                            score += 100;
                        }
                    }
                }
            }
        }
       




    }


    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.WriteLine(enemy);
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;

            if(enemyX < 2)
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22);
            }
        }
    }
    
    public class Item
    {
        public string itemName;
        public string itemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool itemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            itemSprite = "item☆";
            Console.WriteLine(itemSprite);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Player player = new Player();
            Enemy enemy = new Enemy();

            int dwTime = Environment.TickCount;

            while(true)
            {
                if(dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    player.GameMain();

                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }


                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    player.ClashEnemyAndBullet(enemy);
                } 
            }
        }
    }
}
