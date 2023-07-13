using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
    class GamePacManPlayer : GameObject
    {
        public GamePacManPlayer(Image image,GameCell startCell):base (GameObjectType.PLAYER,image) {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction) {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell= currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell) {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

    }

    
}
