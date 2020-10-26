using System.Drawing;

namespace Asteroids.Objects
{
    class Star : BaseObject
    {
        Color color;
        public Star(Point pos, Point dir, Size size, Color color) : base(pos, dir, size)
        {
            this.color = color;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
        }

        public override void Update()
        {
            Pos = new Point(Pos.X - Dir.X, Pos.Y);
            if (Pos.X > Game.Width) Pos = new Point(Size.Width, Pos.Y);
        }
    }
}
