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
                    system("cls");
                    gameRunning = false;
                    printMenu();

                }
                if (timer == 3)
                {
                    moveWickedMagician(Wicked_MagicianX, Wicked_MagicianY, enemydirection1);
                    moveCandy(candyX, candyY, enemydirection2);
                    moveDarkGuardian(DarkGuardianX, DarkGuardianY, enemydirection3);
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
        void printCastle();
        void printGameName();
        void printStory();
        void clearFunction();
        void printMenu();
        void printMaze(char maze[36][114]);
    }
}