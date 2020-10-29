﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Objects
{
    class Asteroid:BaseObject
    {
        Image image;
        public Asteroid(Point pos, Point dir, Size size, Image image) : base(pos, dir, size)
        {
            this.image = image;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(image, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
            Pos = new Point(Pos.X + Dir.X, Pos.Y + Dir.Y);
            if (Pos.X < 0) Dir = new Point(Dir.X * (-1), Dir.Y);
            if (Pos.X > Game.Width) Dir = new Point(Dir.X * (-1), Dir.Y);
            if (Pos.Y < 0) Dir = new Point(Dir.X, Dir.Y * (-1));
            if (Pos.Y > Game.Height) Dir = new Point(Dir.X, Dir.Y * (-1));
        }
    }
}
