using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Pacman_Game.GL
{
    class Grid
    {
        public Cell[][] gameCells;
        public int Rows;
        public int Cols;
        public Grid(string filename,int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            LoadGrid(filename);
        }
        private void LoadGrid(string filename)
        {
            StreamReader file = new StreamReader(filename);
            string record;
            for(int row = 0; row < gameCells.Length; row++)
            {
                record= file.ReadLine();
                for(int col = 0;col< gameCells.Length;col++)
                {
                    Cell cell = new Cell(row,col,this);
                    char displayCharacter = record[col];
                    GameObjectType type = Object.GetGameObjectType(displayCharacter);
                    Object gameObject = new Object(type, displayCharacter);
                    cell.CurrentGameObject = gameObject;
                    gameCells[row][col] = cell;


                }
            }
            file.Close();
        }
        public Cell getCell(int row, int col) 
        {
            Cell cell = new Cell(row, col, this);
            return cell;
        }
    }
}
