using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class Cell : Grid
    {
        public int x;
        public int y;
        public Object CurrentGameObject;
        public Grid gameGrid;
        public Cell(int x, int y, Grid grid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = grid;
        }
        public int nextCell(GameDirection direction)
        {
            if(direction == GameDirection.UP)
            {
                return x-1;
            }
            else if (direction == GameDirection.DOWN)
            {
                return x + 1;
            }
            else if (direction == GameDirection.LEFT)
            {
                return y-1;
            }
            else
            {
                return y+1;
            }
        }
    }
}
