﻿using System.Drawing;

namespace Asteroids.Interfaces
{
    interface ICollision
    {
        bool Collision(ICollision obj);
        Rectangle Rect { get; }
    }
}