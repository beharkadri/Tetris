﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Shape
    {
        public Point Location { get; set; }
        public Tile[] tiles { get; set; }
        public Color Color { get; set; }
        public string Orientation { get; set; }
        public Shape(Point Location, Color Color, string Orientation)
        {
            tiles = new Tile[4];
            this.Color = Color;
            this.Location = Location;
            this.Orientation = Orientation;
        }

        public abstract List<Tile> draw(int cellWidth, int cellHeight);
    }
}
