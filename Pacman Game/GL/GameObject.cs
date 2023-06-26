using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.GL
{
    class GameObject
    {
        public char displayCharacter;
        public Cell CurrentCell;
        public GameObjectType gameObjectType;
        public GameObject(GameObjectType type, char DisplayCharacter)
        {
            gameObjectType = type;
            this.displayCharacter = DisplayCharacter;
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
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public Cell currentCell
        {
            get => CurrentCell;
            set
            {
                CurrentCell = value;
                CurrentCell.CurrentGameObject = this;
            }
        }
    }
}
