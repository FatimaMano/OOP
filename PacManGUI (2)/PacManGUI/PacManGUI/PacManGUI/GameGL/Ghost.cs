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
    public abstract class Ghost : GameObject
    {
        public Ghost(Image image) : base(GameObjectType.ENEMY, image)
        {
        }

        public abstract void Move(GameCell gameCell);
        public abstract GameCell nextCell();

    }
}
