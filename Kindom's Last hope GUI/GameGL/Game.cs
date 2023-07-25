using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Kindom_s_Last_hope_GUI
{
    public class Game
    {
        public static GameObject getBlankGameObject(){
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, Kindom_s_Last_hope_GUI.Properties.Resources.TilePlain);
            return blankGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = Kindom_s_Last_hope_GUI.Properties.Resources.TilePlain;
            if (displayCharacter == '0' || displayCharacter == '$' || displayCharacter == '%' || displayCharacter == '>')
            {
                img = Kindom_s_Last_hope_GUI.Properties.Resources.TileGreen;
            }

            /*if (displayCharacter == '#')
            {
                img = Kindom_s_Last_hope_GUI.Properties.Resources.horizontal;
            }*/

            /*if (displayCharacter == '.')
            {
                img = Kindom_s_Last_hope_GUI.Properties.Resources.pallet;
            }*/
            if (displayCharacter == 'P' || displayCharacter == 'p') {
                img = Kindom_s_Last_hope_GUI.Properties.Resources.Player;
            }

            return img;
        }
    }
}
