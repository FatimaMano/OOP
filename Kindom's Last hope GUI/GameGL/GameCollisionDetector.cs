using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindom_s_Last_hope_GUI.GameGL
{
    class GameCollisionDetector
    {
        public bool isGhostCollideWithPacMan(Ghost ghost)
        {
            bool flag = false;
            //Write your Code Here
            GameCell currentCell = ghost.nextCell();
            if (currentCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                flag = true;
            }
            return flag;
        }

        public bool isBulletCollideWithGhost(Bullet bullet)
        {
            bool flag = false;
            //Write your Code Here
            GameCell currentCell = bullet.nextCell();
            if (currentCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY)
            {
                flag = true;
            }
            return flag;

        }

    }
}
