using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Pacman_Game_GUI.GameGL
{
    class Grid
    {
         Cell[,] gameCells;
         int Rows;
         int Cols;
        public Grid(string filename,int rows, int cols)
        {//Numbers of rows and cols should load from the text file 
            this.Rows = rows;
            this.Cols = cols;
            this.gameCells = new Cell[Rows,Cols];
            LoadGrid(filename);
        }
        public Cell getCell(int x,int y)
        {
            return gameCells[x, y];
        }
        public int rows { get => Rows; set => Rows = value; }
        public int cols { get => Cols; set => Cols = value; }
        private void LoadGrid(string filename)
        {
            StreamReader file = new StreamReader(filename);
            string record;
            for(int row = 0; row < this.Rows; row++)
            {
                record= file.ReadLine();
                for(int col = 0;col< this.Cols;col++)
                {
                    Cell cell = new Cell(row,col,this);
                   /* Console.Write(row + "," + col);
                    Console.ReadLine();*/
                    char displayCharacter = record[col];
                    GameObjectType type = GameObject.GetGameObjectType(displayCharacter);
                    GameObject gameObject = new GameObject(type, displayCharacter);
                    cell.CurrentGameObject = gameObject;
                    gameCells[row,col] = cell;


                }
            }
            file.Close();
        }
    }
}
