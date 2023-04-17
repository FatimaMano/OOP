using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace KindomsLastHope
{
    class Program
    {
        static void Main(string[] args)
        {
            char [,]maze = new char[36,114];
            LoadDataFromUsersFile(maze);
            storeInFile(maze);
            // Array
            int[] bulletX = new int[100];
            int[] bulletY = new int[100];
            bool[] isBulletActive = new bool[100];
            int bulletCount = 0;
            // Prince

            // Enemy1 array

            // Prince coordinates
            int princeX = 20;
            int princeY = 5;
            // Enemy coordinates
            int Wicked_MagicianX = 40;
            int Wicked_MagicianY = 8;
            int candyX = 20;
            int candyY = 8;
            int DarkGuardianX = 90;
            int DarkGuardianY = 4;
            // enemy
            string enemydirection1 = "Up";
            string enemydirection2 = "Left";
            string enemydirection3 = "Up";
            int timer = 0;

            clearFunction();
            printCastle();
            clearFunction();
            printGameName();
            printStory();
            clearFunction();
            printMenu();

            clearFunction();
            printMaze(maze);
            PrintPrince(princeX, princeY);
            PrintEnemyWicked_Magician(Wicked_MagicianX, Wicked_MagicianY);
            /*
            PrintEnemyCandy(candyX, candyY);
            PrintEnemyDarkGuardian(DarkGuardianX, DarkGuardianY);
            */
            bool gameRunning = true;
            while (gameRunning)
            {

                if (GetAsyncKeyState(VK_LEFT))
                {
                    movePrinceLeft(princeX, princeY);
                }
                if (GetAsyncKeyState(VK_RIGHT))
                {
                    movePrinceRight(princeX, princeY);
                }
                if (GetAsyncKeyState(VK_UP))
                {
                    movePrinceUp(princeX, princeY);
                }
                if (GetAsyncKeyState(VK_DOWN))
                {
                    movePrinceDown(princeX, princeY);
                }
                if (GetAsyncKeyState(VK_SPACE))
                {
                    generateBubble(bulletX, bulletY, isBulletActive, princeX, princeY, bulletCount);
                }
                if (GetAsyncKeyState(VK_ESCAPE))
                {
                    Console.Clear();
                    gameRunning = false;
                    //printMenu();

                }
                if (timer == 3)
                {
                    moveWickedMagician(Wicked_MagicianX, Wicked_MagicianY, enemydirection1);
                    /*
                    moveCandy(candyX, candyY, enemydirection2);
                    moveDarkGuardian(DarkGuardianX, DarkGuardianY, enemydirection3);*/
                    timer = 0;
                }
                if (timer == 30)
                {
                    gameRunning = false;
                }
                moveBubble(bulletCount, bulletX, bulletY, isBulletActive);
                bulletCollisionwithEnemy(bulletCount, DarkGuardianX, DarkGuardianY, bulletX, bulletY, candyX, candyY, Wicked_MagicianX, Wicked_MagicianY, isBulletActive);
                timer++;
                printScore();
                Sleep(100);
            }
            /*
        void printCastle();
        void printGameName();
        void printStory();
        void printMenu();
            */
            //Bubble Functions
            static void FireBubble(ref int x, ref int y)
            {
                // Print the bubble at the enemy's position
                Console.SetCursorPosition(x, y - 1);
                Console.WriteLine(" o ");

                // Move the bubble up the screen
                int bubbleY = y - 2;
                while (bubbleY > 0)
                {
                    // Erase the previous position of the bubble
                    Console.SetCursorPosition(x, bubbleY + 2);
                    Console.WriteLine("   ");

                    // Print the new position of the bubble
                    Console.SetCursorPosition(x, bubbleY);
                    Console.WriteLine(" o ");

                    // Pause briefly before moving the bubble again
                    Thread.Sleep(100);

                    // Move the bubble up one row
                    bubbleY--;
                }

                // Erase the final position of the bubble
                Console.SetCursorPosition(x, bubbleY + 2);
                Console.WriteLine("   ");
            }

            static void GenerateBubble(ref int[] bulletX, ref int[] bulletY, ref bool[] isBulletActive, int princeX, int princeY, ref int bulletCount)
            {
                bulletX[bulletCount] = princeX + 4;
                bulletY[bulletCount] = princeY;
                isBulletActive[bulletCount] = true;

                // Generate a random color
                int color = new Random().Next(1, 16);
                Console.ForegroundColor = (ConsoleColor)color;

                Console.SetCursorPosition(princeX + 4, princeY);
                Console.Write("o");
                bulletCount++;
            }

            static void MoveBubble(ref int bulletCount, ref int[] bulletX, ref int[] bulletY, ref bool[] isBulletActive)
            {
                for (int x = 0; x < bulletCount; x++)
                {
                    if (isBulletActive[x] == true)
                    {
                        char next = maze(bulletX[x] + 1, bulletY[x]);
                        if (next != ' ')
                        {
                            EraseBubble(bulletX[x], bulletY[x]);
                            MakeBubbleInactive(x, ref isBulletActive);
                        }
                        else
                        {
                            EraseBubble(bulletX[x], bulletY[x]);
                            bulletX[x] = bulletX[x] + 1;
                            PrintBubble(bulletX[x], bulletY[x]);
                        }
                    }
                }
            }

            static void PrintBubble(int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("o");
            }

            static void EraseBubble(int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
            }

            static void MakeBubbleInactive(int index, ref bool[] isBulletActive)
            {
                isBulletActive[index] = false;
            }

            static void PrintMaze(char[,] maze)
            {
                Random rand = new Random();
                for (int i = 0; i < 36; i++)
                {
                    for (int j = 0; j < 114; j++)
                    {
                        // generate a random color between 1 and 15
                        int color = rand.Next(1, 16);
                        Console.ForegroundColor = (ConsoleColor)color;
                        Console.Write(maze[i, j]);
                    }
                    Console.WriteLine();
                }
            }

        }