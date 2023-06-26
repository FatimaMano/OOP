using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class Player : GameObject
    {
        public Player(char displayCharacter,Cell startCell):base( GameObjectType.PLAYER, displayCharacter) 
        {
            this.currentCell = startCell;
        }
        public Cell move(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }
    }
}
