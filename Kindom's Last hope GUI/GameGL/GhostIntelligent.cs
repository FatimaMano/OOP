using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Kindom_s_Last_hope_GUI
{
    public interface IDistanceCalculator
    {
        double CalculateDistance(GameCell cell1, GameCell cell2);
    }
    public class GhostIntelligent : Ghost, IDistanceCalculator
    {
        private GameObject player;
        private int enemylives;

        public GhostIntelligent(Image image, GameCell startCell, GameObject player, int lives) : base(image)
        {
            this.player = player;
            this.CurrentCell = startCell;
            this.enemylives = lives;
        }

        public override void Move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());
            }
            this.CurrentCell = gameCell;
            gameCell.setGameObject(this);
        }

        public override GameCell nextCell()
        {
            double[] distance = new double[4] { 10000, 10000, 10000, 10000 };
            GameCell playerCell = player.CurrentCell;

            // Calculate the distance to the player in different directions
            if (this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                distance[0] = CalculateDistance(this.CurrentCell.nextCell(GameDirection.Left), playerCell);
            }
            if (this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                distance[1] = CalculateDistance(this.CurrentCell.nextCell(GameDirection.Right), playerCell);
            }
            if (this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                distance[2] = CalculateDistance(this.CurrentCell.nextCell(GameDirection.Up), playerCell);
            }
            if (this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.WALL)
            {
                distance[3] = CalculateDistance(this.CurrentCell.nextCell(GameDirection.Down), playerCell);
            }

            // Determine the direction with the minimum distance to the player
            int minIndex = 0;
            double minDistance = distance[0];
            for (int i = 1; i < distance.Length; i++)
            {
                if (distance[i] < minDistance)
                {
                    minDistance = distance[i];
                    minIndex = i;
                }
            }

            // Set the direction based on the minimum distance
            GameDirection direction;
            switch (minIndex)
            {
                case 0:
                    direction = GameDirection.Left;
                    break;
                case 1:
                    direction = GameDirection.Right;
                    break;
                case 2:
                    direction = GameDirection.Up;
                    break;
                case 3:
                    direction = GameDirection.Down;
                    break;
                default:
                    direction = GameDirection.Left; // Default direction (can be any valid direction)
                    break;
            }

            return this.CurrentCell.nextCell(direction);
        }

        // Helper method to calculate the distance between two cells
        public double CalculateDistance(GameCell cell1, GameCell cell2)
        {
            return Math.Sqrt(Math.Pow((cell2.X - cell1.X), 2) + Math.Pow((cell2.Y - cell1.Y), 2));
        }
    }
}
