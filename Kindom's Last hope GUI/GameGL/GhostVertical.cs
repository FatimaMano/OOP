﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Kindom_s_Last_hope_GUI
{
    public class GhostVertical : Ghost
    {
        GameDirection direction = GameDirection.Down;
        private int enemylives;
        public GhostVertical(Image ghostImage, GameCell startCell, int lives) : base(ghostImage)
        {
            this.CurrentCell = startCell;
        }

        public override void Move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);

            if (potentialNextCell == nextCell)
            {
                if (direction == GameDirection.Up)
                {
                    direction = GameDirection.Down;
                }
                else if (direction == GameDirection.Down)
                {
                    direction = GameDirection.Up;
                }
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;

        }

    }
}
