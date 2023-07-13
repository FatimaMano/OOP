using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan.GameGL
{
    abstract class Ghost : GameObject
    {
        public Ghost(Image image, GameCell startCell) : base(GameObjectType.ENEMY, image)
        {
            this.CurrentCell = startCell;
        }
        public abstract void Move(PictureBox ghost, ref string ghostDirection);

    }
}
