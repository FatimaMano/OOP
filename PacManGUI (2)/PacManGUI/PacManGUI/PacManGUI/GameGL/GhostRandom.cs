using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace PacMan.GameGL
{
     class GhostRandom : Ghost
    {
        public GhostRandom(Image image, GameCell startCell) : base(image, startCell)
        {
            this.CurrentCell = startCell;
        }
        // Complete this Function on your own
        public override void Move(PictureBox ghost, ref string ghostDirection)
        {
        }
    }
}
