using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacMan.GameGL
{
     class GhostVertical : Ghost
    {
        public GhostVertical(Image image, GameCell startCell) : base(image, startCell)
        {
            this.CurrentCell = startCell;
        }
        public override void Move(PictureBox ghost, ref string ghostDirection)
        {
            if (ghostDirection == "Top")
            {
                ghost.Left = ghost.Top + 10;
            }
            if (ghostDirection == "Bottom")
            {
                ghost.Left = ghost.Top - 10;
            }
            if ((ghost.Left + ghost.Width) > ghost.Width)
            {
                ghostDirection = "Top";
            }
            if (ghost.Left <= 2)
            {
                ghostDirection = "Bottom";
            }
        }
    }
}
