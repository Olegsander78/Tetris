﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Figure
    {
       protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }

        public void Move(Direction dir)
        {
            foreach (Point item in points)
            {
                item.Move(dir);
            }
        }

        internal void Hide()
        {
            foreach (Point item in points)
            {
                item.Hide();
            }
        }
    }
}
