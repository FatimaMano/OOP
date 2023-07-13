using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan.GameGL
{
     class GhostHorizontal : Ghost
    {
        public GhostHorizontal(Image image, GameCell startCell) : base(image, startCell)
        {
            this.CurrentCell = startCell;
        }
        public override void Move(PictureBox ghost,ref string ghostDirection)
        {
            if(ghostDirection == "Left")
            {
                ghost.Left = ghost.Left + 10;
            }
            if(ghostDirection == "Right")
            {
                ghost.Left = ghost.Left - 10;
            }
            if((ghost.Left + ghost.Width) > ghost.Width)
            {
                ghostDirection = "Left";
            }
            if(ghost.Left <=2)
            {
                ghostDirection = "Right";
            }
        }

    }
}
