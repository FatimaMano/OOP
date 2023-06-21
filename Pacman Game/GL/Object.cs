using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class Object
    {
        public char DisplayCharacter;
        public Cell CurrentCell;
        public Enum GameObjectType;
        public Object(GameObjectType type, char DisplayCharacter)
        {
            GameObjectType = type;
            this.DisplayCharacter = DisplayCharacter;
        }
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            if(displayCharacter == '#' || displayCharacter == '|' || displayCharacter == '%')
            {
                return GL.GameObjectType.WALL;
            }
            else if (displayCharacter == '.')
            {
                return GL.GameObjectType.REWARD;
            }
            else if (displayCharacter == 'P')
            {
                return GL.GameObjectType.PLAYER;
            }
            else if (displayCharacter == 'G')
            {
                return GL.GameObjectType.ENEMY;
            }
            else
            {
                return GL.GameObjectType.NONE;
            }
        }
        public void MoveGameObject(GameObjectType type, GameDirection direction)
        {
            if(type == GL.GameObjectType.PLAYER) 
            {
                Player.move(direction);
            }
        }
    }
}
