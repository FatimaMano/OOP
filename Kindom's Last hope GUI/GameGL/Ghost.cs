using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Kindom_s_Last_hope_GUI
{
    public abstract class Ghost : GameObject
    {
        private int enemylives;
        public Ghost(Image image) : base(GameObjectType.ENEMY, image)
        {
        }


        public abstract GameCell nextCell();
        public abstract void Move(GameCell gameCell);

    }
}
