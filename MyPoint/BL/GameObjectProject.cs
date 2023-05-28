using System;
using BoundaryProject.BL;
using MyPoint.BL;
namespace BoundaryProject.BL
{
    class GameObject
    {
        public char[,] Shape { get; set; }
        public Point StartingPoint { get; set; }
        public Boundary Premises { get; set; }
        public string Direction { get; set; }
        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] shape, Point point)
        {
            Shape = shape;
            StartingPoint = point;
        }
        public GameObject(char[,] shape, Point startingPoint, Boundary premises, string direction)
        {
            Shape = shape;
            StartingPoint = startingPoint;
            Premises = premises;
            Direction = direction;
        }
        public void Move()
        {
            if (Direction == "LeftToRight")
            {
                MoveRight();
            }
            else if (Direction == "RightToLeft")
            {
                MoveLeft();
            }
            else if (Direction == "Patrol")
            {
                MovePatrol();
            }
            else if (Direction == "Projectile")
            {
                MoveProjectile();
            }
            else if (Direction == "Diagonal")
            {
                MoveDiagonal();
            }
        }

        private void MoveRight()
        {
            if (StartingPoint.X + Shape.GetLength(1) < Premises.TopRight.X)
            {
                StartingPoint.X += 1; // Move one step to the right
            }
        }

        private void MoveLeft()
        {
            if (StartingPoint.X > Premises.TopLeft.X)
            {
                StartingPoint.X -= 1; // Move one step to the left
            }
        }

        private void MovePatrol()
        {
            if (StartingPoint.X > Premises.TopLeft.X && StartingPoint.X + Shape.GetLength(1) < Premises.TopRight.X)
            {
                StartingPoint.X += 1; // Move one step to the right
            }
            else
            {
                Direction = "RightToLeft"; // Reverse the direction
            }
        }

        private void MoveProjectile()
        {
            if (StartingPoint.Y - 5 >= Premises.TopLeft.Y && StartingPoint.X + 2 + Shape.GetLength(1) <= Premises.TopRight.X)
            {
                StartingPoint.Y -= 5; // Move 5 steps towards the top
                StartingPoint.X += 2; // Move 2 steps towards the right
            }
            else if (StartingPoint.Y + 4 + Shape.GetLength(0) <= Premises.BottomLeft.Y && StartingPoint.X + 2 + Shape.GetLength(1) <= Premises.TopRight.X)
            {
                StartingPoint.Y += 4; // Move 4 steps towards the bottom
                StartingPoint.X += 2; // Move 2 steps towards the right
            }
        }

        private void MoveDiagonal()
        {
            if (StartingPoint.X + Shape.GetLength(1) < Premises.TopRight.X && StartingPoint.Y + Shape.GetLength(0) < Premises.BottomRight.Y)
            {
                StartingPoint.X += 1; // Move one step towards the right
                StartingPoint.Y += 1; // Move one step towards the bottom
            }
        }


    }
}
