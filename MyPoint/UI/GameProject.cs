using System;
using GameObjectProject.BL;

namespace GameProject.DL
{
    public class GameProjectUI
    {
        public void Erase()
        {
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(StartingPoint.X + j, StartingPoint.Y + i);
                    Console.Write(" ");
                }
            }
        }


        public void Draw()
        {
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(StartingPoint.X + j, StartingPoint.Y + i);
                    Console.Write(Shape[i, j]);
                }
            }
        }

    }


}
