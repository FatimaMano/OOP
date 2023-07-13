using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
namespace PacManGUI
{
    public partial class Form1 : Form
    {
        GamePacManPlayer pacman;
        PictureBox GhostPink;
        PictureBox GhostBlue;
        PictureBox GhostRed;
        PictureBox GhostOrange;
        public string GhostPinkDirection = "Left";
        public string GhostBlueDirection = "Top";
        public string GhostRedDirection = "Right";

        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GhostPink = createEnemy(PacManGUI.Properties.Resources.ghost_pink);
            GhostBlue = createEnemy(PacManGUI.Properties.Resources.ghost_blue);
            GhostRed = createEnemy(PacManGUI.Properties.Resources.ghost_red);
            GhostOrange = createEnemy(PacManGUI.Properties.Resources.ghost_orange);
            this.Controls.Add(GhostPink);
            this.Controls.Add(GhostBlue);
            this.Controls.Add(GhostRed);
            this.Controls.Add(GhostOrange);
            GameGrid grid = new GameGrid("maze.txt", 20, 70);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell);
            printMaze(grid);
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
            if(Keyboard.IsKeyPressed(Key.LeftArrow)) {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow)){
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow)){
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow)){
                pacman.move(GameDirection.Down);
            }
            



        }
        private PictureBox createEnemy(Image img)
        {
            PictureBox pbEnemy = new PictureBox();
            Random rand = new Random();
            int left = rand.Next(10, this.Width);
            int top = rand.Next(10, this.Height+20);
            pbEnemy.Left = left;
            pbEnemy.Top = top;
            pbEnemy.Height = this.Height;
            pbEnemy.Width = this.Width;
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.Image = img;
            return pbEnemy;


        }
    }
}
