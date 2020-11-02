using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.Objects
{

    class Ship : BaseObject
    {
        public static event Message MessageDie;

        Image image;

        private int _energy = 100;
        public int Energy
        {
            get => _energy;
            set => _energy = value;
        }

        public void EnergyLow(int n)
        {
            _energy -= n;
        }

        public void AidPack(int n)
        {
            _energy += n;
        }
        public Ship(Point pos, Point dir, Size size, Image image) : base(pos, dir, size)
        {
            this.image = image;
        }

        public override void Draw()
        {
            Game.Buffer.Graphics.DrawImage(image, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {

        }
        public void Up()
        {
            if (Pos.Y > 0) Pos = new Point(Pos.X, Pos.Y - Dir.Y);
        }
        public void Down()
        {
            if (Pos.Y < Game.Height) Pos = new Point(Pos.X, Pos.Y + Dir.Y);
        }
        public void Die()
        {
            MessageDie?.Invoke();
        }
    }
}
