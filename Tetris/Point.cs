﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Point
    {
        int x;
        int y;
        char c;

        void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
