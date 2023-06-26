using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class Ghost
    {
        public abstract Cell Move()
        {
            return new Cell();  
        }

    }
}
