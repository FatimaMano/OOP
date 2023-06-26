using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class Cell
    {
        private int x;
        private int y;
        private GameObject currentGameObject;
        private Grid gameGrid;
        public Cell(int x, int y, Grid grid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid = grid;
        }
        public Cell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.LEFT)
            {
                if(this.y>0)
                {
                    Cell ncell = gameGrid.getCell(x, y - 1);
                    if (ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            if(direction == GameDirection.RIGHT)
            {
                if(this.y < gameGrid.cols -1 )
                {
                    Cell ncell = gameGrid.getCell(this.x, this.y + 1);
                    if(ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }

                }
            }
            if (direction == GameDirection.UP)
            {
                if(this.x > 0)
                {
                    Cell ncell = gameGrid.getCell(this.x-1,this.y);
                    if(ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            if (direction == GameDirection.DOWN)
            {
                if(this.x < gameGrid.rows-1)
                {
                    Cell ncell = gameGrid.getCell(this.x + 1, this.y);
                    if(ncell.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return ncell;
                    }
                }
            }
            return this;
        }
        public int X { get => x; set => x= value; }
        public  int Y { get => y; set => y= value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }


    }
}
