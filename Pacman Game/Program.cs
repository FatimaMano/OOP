using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using Pacman_Game.GL;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid("C:\\Users\\HP\\source\\repos\\Pacman Game\\Maze.txt", 24, 69);
            Cell start = new Cell(12, 22, grid);
            Player pacman = new Player('P', start);
            printMaze(grid);
            printGameObject(pacman);

            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.UP);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.DOWN);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.RIGHT);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.LEFT);
                }
            }
        }
        static void clearGameCellContent(Cell gameCell,GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.Y, gameCell.X);
            Console.Write(newGameObject.DisplayCharacter);

        }
        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.Y, gameObject.CurrentCell.X);
            Console.Write(gameObject.DisplayCharacter);

        }

        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            Cell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                Cell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void printMaze(Grid grid)
        {
            for (int x = 0; x < grid.rows; x++)
            {
                for (int y = 0; y < grid.cols; y++)
                {
                    Cell cell = grid.getCell(x, y);
                    printCell(cell);
                }

            }
        }

        static void printCell(Cell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

    }
}

