using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
   abstract class Figure
    {

        const int LENGHT = 4;
        public Point[] Points = new Point[LENGHT];

        public void Draw()
        {
            foreach (var item in Points)
            {
                item.Draw();
            }
        }

        internal Result TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);

            var result = VerifyPosition(clone);
            if(result==Result.SUCCESS)
            {
                Points = clone;
            }

            Draw();
            return result;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if(result==Result.SUCCESS)
            {
                Points = clone;
            }

            Draw();
            return result;
        }

        private Result VerifyPosition(Point[] newPoints)
        {
            foreach (var p in newPoints)
            {
                if (p.Y >= Field.Height)
                    return Result.DOWN_BORDER_STRIKE;

                if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;

                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCESS;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGHT];
            for (int i = 0; i < LENGHT; i++)
            {
                newPoints[i] = new Point(Points[i]);
            }
            return newPoints;
        }

        public void Move(Point[] plist, Direction dir)
        {
            foreach(var p in plist)
            {
                p.Move(dir);
            }
        }

       

        public abstract void Rotate(Point[] pList);

        internal void Hide()
        {
            foreach (Point item in Points)
            {
                item.Hide();
            }
        }

        
    }
}
