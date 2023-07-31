using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using Kindom_s_Last_hope_GUI.GameGL;

namespace Kindom_s_Last_hope_GUI
{
    public partial class Form1 : Form
    {
        GamePlayer player;
        GameCollisionDetector collisionDetector;
        public List<Ghost> ghosts = new List<Ghost>();
        Timer gameLoopTimer;
        public List<Bullet> bullets = new List<Bullet>();
        int bulletCount = 3;
        int score = 0;
        int lives = 3;
        public Form1()
        {
            InitializeComponent();
            // Initialize the game loop timer
            gameLoop = new Timer();
            gameLoop.Interval = 50; // Adjust the interval based on your game's needs
            gameLoop.Tick += gameLoop_Tick;
            gameLoop.Start();
            collisionDetector = new GameCollisionDetector();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            GameGrid grid = new GameGrid("mazes.txt", 26, 69);
            Image Player = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            player = new GamePlayer(Player, startCell);
            GhostVertical gv1 = new GhostVertical(Properties.Resources.EnemyMain, grid.getCell(3, 6),15);
            GhostVertical gv2 = new GhostVertical(Properties.Resources.EnemyMain, grid.getCell(5, 3),15);
            GhostHorizontal gv3 = new GhostHorizontal(Properties.Resources.EnemyTurtle, grid.getCell(6, 26),15);
            GhostHorizontal gv4 = new GhostHorizontal(Properties.Resources.EnemyTurtle, grid.getCell(2, 26), 15);
            GhostHorizontal gv5 = new GhostHorizontal(Properties.Resources.EnemyTurtle, grid.getCell(11, 26), 15);
            GhostHorizontal gv6 = new GhostHorizontal(Properties.Resources.EnemyTurtle, grid.getCell(13, 26), 15);
            //GhostIntelligent gv4 = new GhostIntelligent(Properties.Resources.EnemyTurtle, grid.getCell(12, 30),player,15);
            addGhost(gv1);
            addGhost(gv2);
            addGhost(gv3);
            addGhost(gv4);
            addGhost(gv5);
            addGhost(gv6);
            player = new GamePlayer(Player, startCell);
            printMaze(grid);
        }
        public void addGhost(Ghost ghost)
        {
            ghosts.Add(ghost);
        }
        /*public void GenerateBullet()
        {
            // Get the player's current cell
            GameCell playerCell = player.CurrentCell;

            // Calculate the initial direction of the bullet based on the player's direction
            GameDirection bulletDirection = player.Direction;

            // Calculate the initial position of the bullet (offset from the player's cell)
            int bulletX = playerCell.X;
            int bulletY = playerCell.Y;
            switch (player.Direction)
            {
                case GameDirection.Left:
                    bulletY -= 1;
                    break;
                case GameDirection.Right:
                    bulletY += 1;
                    break;
                case GameDirection.Up:
                    bulletX -= 1;
                    break;
                case GameDirection.Down:
                    bulletX += 1;
                    break;
            }

            // Check if the initial position is valid (within the game grid)
            if (bulletX >= 0 && bulletX < GameGrid.Rows && bulletY >= 0 && bulletY < GameGrid.Cols)
            {
                // Create a new bullet instance and add it to the list of bullets
                Bullet newBullet = new Bullet(GameGrid.getCell(bulletX, bulletY), bulletDirection);
                bullets.Add(newBullet);

                // Optionally, add the bullet to the game grid or GUI (if required)
                // Example: this.Controls.Add(newBullet.PictureBox);
            }
        }*/
        public void GenerateBullet()
        {
            Image bulletImage = Properties.Resources.Bullet; // Assuming you have a method to get the bullet image
            GameCell startBulletCell = player.CurrentCell.nextCell(GameDirection.Right);
            Bullet bullet = new Bullet(bulletImage, startBulletCell, GameDirection.Right);
            bullets.Add(bullet);
        }



        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                    //        printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }


        private void gameLoop_Tick(object sender, EventArgs e)
        {
            
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                GenerateBullet();
            }
            moveBullet();
            moveGhosts();
            showScore();

        }
        public void moveGhosts()
        {
            foreach (Ghost g in ghosts)
            {
                if (collisionDetector.isGhostCollideWithPacMan(g))
                {
                    addScorePoints(-1);
                }
                g.Move(g.nextCell());


            }
        }
        public void moveBullet()
        {
            foreach (Bullet bullet in bullets)
            {
                if (collisionDetector.isBulletCollideWithGhost(bullet))
                {
                    addScorePoints(1);
                }
                bullet.Move(bullet.nextCell());


            }
        }
        public void addScorePoints(int points)
        {
            this.score = score + points;
        }
        public int getScore()
        {
            return score;
        }
        private void showScore()
        {

            lblScoreValue.Text = getScore().ToString();
        }
        private void HandleBulletMovement()
        {
            List<Bullet> bulletsToRemove = new List<Bullet>();
            foreach (Bullet bullet in bullets)
            {
                GameCell nextCell = bullet.nextCell();
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.WALL)
                {
                    bulletsToRemove.Add(bullet);
                }
                else
                {
                    bullet.Move(nextCell);
                }
            }

            foreach (Bullet bullet in bulletsToRemove)
            {
                bullets.Remove(bullet);
            }
        }

        private void CheckCollisions()
        {
            // Check collisions between player and ghosts
            foreach (Ghost ghost in ghosts)
            {
                if (collisionDetector.isGhostCollideWithPacMan(ghost))
                {
                    lives--;
                    // Handle game over or other consequences when the player collides with a ghost
                    // Implement the logic for handling lives and game over here
                }
            }
            List<Ghost> ghostsToRemove = new List<Ghost>();
            foreach (Ghost ghost in ghosts)
            {
                foreach (Bullet bullet in bullets)
                {
                    if (collisionDetector.isBulletCollideWithGhost(bullet))
                    {
                        ghostsToRemove.Add(ghost);
                    }
                }
            }

            foreach (Ghost ghost in ghostsToRemove)
            {
                deleteGhost(ghost);
            }
        }
        public void deleteGhost(Ghost ghost)
        {
            ghosts.Remove(ghost);
        }

    }
}
