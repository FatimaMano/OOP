﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
     class GhostHorizontal : Ghost
    {
        public GhostHorizontal(char displayCharacter, Cell startCell) : base(displayCharacter, startCell)
        {
            this.currentCell = startCell;
        }
        public Cell Move()
        {
            return new Cell();
        }

    }
}
