using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kindom_s_Last_hope_GUI.GameGL
{
    public class Bullet : GameObject
    {
        public GameDirection Direction { get; private set; }
        private readonly GameGrid gameGrid;

        public Bullet(Image image,GameCell initialCell, GameDirection initialDirection) : base(GameObjectType.BULLET, image)
        {
            CurrentCell = initialCell;
            Direction = initialDirection;
        }
        public void Move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public GameCell nextCell()
        {
                GameCell potentialNextCell = this.CurrentCell.nextCell(Direction);

                // Check if the next cell is not blocked by obstacles
                if (potentialNextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                    potentialNextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
                {
                    return potentialNextCell;
                }

            // If the next cell is invalid or blocked, return the current cell (bullet doesn't move)
            return CurrentCell;
        }
    }
}
