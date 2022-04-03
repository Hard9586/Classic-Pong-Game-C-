﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SimpleGameSnake.GameLibrary
{
    [DebuggerDisplay("X: {X}, Y: {Y}")]
    public struct Point
    {
        public int X { get; init; }
        public int Y { get; init; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
