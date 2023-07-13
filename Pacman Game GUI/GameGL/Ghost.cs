using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game_GUI.GameGL
{
    class Ghost : GameObject
    {
        public Ghost(char displayCharacter, Cell startCell) : base(GameObjectType.ENEMY, displayCharacter)
        {
            this.currentCell = startCell;
        }
        public abstract Cell Move()
        {
            return new Cell();  
        }

    }
}
