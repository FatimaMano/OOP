using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class Player : Object
    {
        public Player(GameObjectType type, char DisplayCharacter) : base(type, DisplayCharacter)
        {
        }
        public Cell move(GameDirection direction)
        {
            if(direction == GameDirection.UP)
            { 
                Console.WriteLine()
            }
        }
    }
}
