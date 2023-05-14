using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using EZInput;

namespace KindomsLastHope
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] maze = new char[36, 114];
            LoadDataFromUsersFile(ref maze);
            storeInFile(maze);
            // Array
            int[] bulletX = new int[100];
            int[] bulletY = new int[100];
            bool[] isBulletActive = new bool[100];
            int bulletCount = 0;
            int score = 0;
            // Prince

            // Enemy1 array

            // Prince coordinates
            int princeX = 20;
            int princeY = 5;
            // Enemy coordinates
            int Wicked_MagicianX = 40;
            int Wicked_MagicianY = 8;
            /*
            int candyX = 20;
            int candyY = 8;
            int DarkGuardianX = 90;
            int DarkGuardianY = 4;
            */
            // enemy
            string enemydirection1 = "Up";
            //string enemydirection2 = "Left";
            //string enemydirection3 = "Up";
            int timer = 0;
            /*
            clearFunction();
            printCastle();
            clearFunction();
            printGameName();
            printStory();
            clearFunction();
            printMenu();
            */


            Console.Clear();
            PrintMaze(maze);
            PrintPrince(princeX, princeY);
            PrintEnemyWicked_Magician(Wicked_MagicianX, Wicked_MagicianY);
            /*
            PrintEnemyCandy(candyX, candyY);
            PrintEnemyDarkGuardian(DarkGuardianX, DarkGuardianY);
            */
            bool gameRunning = true;
            while (gameRunning)
            {

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movePrinceLeft(ref princeX, ref princeY, ref maze);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePrinceRight(ref princeX, ref princeY, ref maze);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    movePrinceUp(ref princeX, ref princeY, ref maze);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movePrinceDown(ref princeX, ref princeY, ref maze);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    GenerateBubble(ref bulletX, ref bulletY, ref isBulletActive, princeX, princeY, ref bulletCount);
                }
                if (Keyboard.IsKeyPressed(Key.Escape))
                {
                    Console.Clear();
                    gameRunning = false;
                    //printMenu();

                }
                if (timer == 3)
                {
                    moveWickedMagician(ref Wicked_MagicianX, ref Wicked_MagicianY, ref enemydirection1, ref maze);
                    /*
                    moveCandy(candyX, candyY, enemydirection2);
                    moveDarkGuardian(DarkGuardianX, DarkGuardianY, enemydirection3);*/
                    timer = 0;
                }
                if (timer == 30)
                {
                    gameRunning = false;
                }
                moveBubble(ref bulletCount, ref bulletX, ref bulletY, ref isBulletActive, ref maze);
                bulletCollisionwithEnemy(bulletCount, bulletX, bulletY, Wicked_MagicianX, Wicked_MagicianY, isBulletActive, score);
                timer++;
                printScore(ref score);
                Thread.Sleep(100);
            }
        }
        //File Handling
        static void LoadDataFromUsersFile(ref char[,] maze)
        {
            StreamReader file = new StreamReader("C:\Users\HP\source\repos\Kindom's last Hope Version 1 C#\Kindom's last Hope Version 1\mazes.txt");
            int j = 0;
            string Maze;
            while ((Maze = file.ReadLine()) != null)
            {
                for (int i = 0; i < 114; i++)
                {
                    maze[j, i] = Maze[i];
                }
                j++;
            }
            file.Close();
        }

        static void storeInFile(char[,] maze)
        {
            StreamWriter file = new StreamWriter("C:\\Users\\HP\\source\\repos\\Kindom's last Hope Version 1 C#\\Kindom's last Hope Version 1\\mazes.txt");
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 114; j++)
                {
                    file.Write(maze[i, j]);
                }
                file.WriteLine();
            }
            file.Close();
        }



        /*
    void printCastle();
    void printGameName();
    void printStory();
    void printMenu();
        */
        //Prince

        static void PrintPrince(int princeX, int princeY)
        {
            char[,] printPrince = new char[,] {
                        {' ', 'o', ' ', ' '},
                        {'/', '|', '\\', ' '},
                        {'/', ' ', '\\', ' '}
                };

            Console.SetCursorPosition(princeX, princeY);
            for (int index = 0; index < 4; index++)
            {
                Console.Write(printPrince[0, index]);
            }
            Console.SetCursorPosition(princeX, princeY + 1);
            for (int index = 0; index < 4; index++)
            {
                Console.Write(printPrince[1, index]);
            }
            Console.SetCursorPosition(princeX, princeY + 2);
            for (int index = 0; index < 4; index++)
            {
                Console.Write(printPrince[2, index]);
            }
        }

        static void movePrinceLeft(ref int princeX, ref int princeY, ref char[,] maze)
        {
            char next = maze[princeY, princeX - 1];
            if (next == ' ')
            {
                erasePrince(princeX, princeY);
                princeX--;
                PrintPrince(princeX, princeY);
            }
        }

        static void movePrinceRight(ref int princeX, ref int princeY, ref char[,] maze)
        {
            char next = maze[princeY, princeX + 4];
            if (next == ' ')
            {
                erasePrince(princeX, princeY);
                princeX++;
                PrintPrince(princeX, princeY);
            }
        }

        static void movePrinceUp(ref int princeX, ref int princeY, ref char[,] maze)
        {
            char next = maze[princeY - 1, princeX];
            if (next == ' ')
            {
                erasePrince(princeX, princeY);
                princeY--;
                PrintPrince(princeX, princeY);
            }
        }

        static void movePrinceDown(ref int princeX, ref int princeY, ref char[,] maze)
        {
            char next = maze[princeX, princeY + 3];
            if (next == ' ')
            {
                erasePrince(princeX, princeY);
                princeY++;
                PrintPrince(princeX, princeY);
            }
        }

        static void erasePrince(int princeX, int princeY)
        {
            Console.SetCursorPosition(princeX, princeY);
            for (int index = 0; index < 4; index++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(princeX, princeY + 1);
            for (int index = 0; index < 4; index++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(princeX, princeY + 2);
            for (int index = 0; index < 4; index++)
            {
                Console.Write(" ");
            }
        }
        static void PrintEnemyWicked_Magician(int Wicked_MagicianX, int Wicked_MagicianY)
        {
            char[,] Wicked_Magician = new char[,]
            {
                  { ' ', ' ', '/', '\\', ' ', ' ', ' ', ' ' },
                  { ' ', '(', ' ', 'o', ' ', ')', ' ', ' ' },
                  { ' ', '/', '|', '|', '\\', ' ', ' ', ' ' },
                  { '/', '|', '|', '|', '|', '\\', ' ', ' ' }
            };
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY);
            for (int index = 0; index < 8; index++)
            {
                Console.Write(Wicked_Magician[0, index]);
            }
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY + 1);
            for (int index = 0; index < 8; index++)
            {
                Console.Write(Wicked_Magician[1, index]);
            }
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY + 2);
            for (int index = 0; index < 8; index++)
            {
                Console.Write(Wicked_Magician[2, index]);
            }
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY + 3);
            for (int index = 0; index < 8; index++)
            {
                Console.Write(Wicked_Magician[3, index]);
            }
        }

        static void moveWickedMagician(ref int Wicked_MagicianX, ref int Wicked_MagicianY, ref string enemydirection1, ref char[,] maze)
        {
            if (enemydirection1 == "Up")
            {
                char next = maze[Wicked_MagicianY - 1, Wicked_MagicianX, ];
                if (next == ' ')
                {
                    eraseWickedMagician(Wicked_MagicianX, Wicked_MagicianY);
                    Wicked_MagicianY--;
                    PrintEnemyWicked_Magician(Wicked_MagicianX, Wicked_MagicianY);
                }
                if (next == '0' || next == '%' || next == '\\' || next == '>')
                {
                    enemydirection1 = "Down";
                }
            }
            if (enemydirection1 == "Down")
            {
                char next = maze[Wicked_MagicianY + 4, Wicked_MagicianX];
                if (next == ' ')
                {
                    eraseWickedMagician(Wicked_MagicianX, Wicked_MagicianY);
                    Wicked_MagicianY++;
                    PrintEnemyWicked_Magician(Wicked_MagicianX, Wicked_MagicianY);
                }
                if (next == '0' || next == '%' || next == '\\' || next == '>')
                {
                    enemydirection1 = "Up";
                }
            }
        }

        static void eraseWickedMagician(int Wicked_MagicianX, int Wicked_MagicianY)
        {
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY);
            for (int index = 0; index < 8; index++)
            {
                Console.WriteLine(" ");
            }
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY + 1);
            for (int index = 0; index < 8; index++)
            {
                Console.WriteLine(" ");
            }
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY + 2);
            for (int index = 0; index < 8; index++)
            {
                Console.WriteLine(" ");
            }
            Console.SetCursorPosition(Wicked_MagicianX, Wicked_MagicianY + 3);
            for (int index = 0; index < 8; index++)
            {
                Console.WriteLine(" ");
            }
        }

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

        static void moveBubble(ref int bulletCount, ref int[] bulletX, ref int[] bulletY, ref bool[] isBulletActive, ref char[,] maze)
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {
                    char next = maze[bulletY[x], bulletX[x] + 1];
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
        // Bubble collision with enemy
        static void bulletCollisionwithEnemy(int bulletCount, int[] bulletX, int[] bulletY, int Wicked_MagicianX, int Wicked_MagicianY, bool[] isBulletActive, ref int score)
        {
            for (int x = 0; x < bulletCount; x++)
            {
                if (isBulletActive[x] == true)
                {
                    /*if (bulletX[x] + 1 == DarkGuardianX && (bulletY[x] == DarkGuardianY || DarkGuardianY + 1 == bulletY[x] || bulletY[x] == DarkGuardianY + 2 || bulletY[x] == DarkGuardianY + 3))
                    {
                        addScore(score);
                    }
                    if (bulletX[x] + 1 == candyX && (bulletY[x] == candyY || candyY + 1 == bulletY[x] || bulletY[x] == candyY + 2))
                    {
                        addScore(score);
                    }*/
                    if (bulletX[x] + 1 == Wicked_MagicianX && (bulletY[x] == Wicked_MagicianY || Wicked_MagicianY + 1 == bulletY[x] || bulletY[x] == Wicked_MagicianY + 2 || bulletY[x] == Wicked_MagicianY + 3))
                    {
                        addScore(ref score);
                    }
                }
            }
        }
        //Score

        static void addScore(ref int score)
        {
            score++;
        }
        static void printScore(ref int score)
        {
            Console.SetCursorPosition(150, 8);
            Console.WriteLine("Score: {0}", score);
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
}

        