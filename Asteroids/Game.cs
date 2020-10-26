using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Asteroids.Objects;

namespace Asteroids
{
    static class Game
    {
        static public ulong Counter { get; private set; } = 0;
        static BufferedGraphicsContext context;
        static public BufferedGraphics Buffer { get; private set; }
        static public Random Random { get; } = new Random();
        static public int Width { get; private set; }
        static public int Height { get; private set; }
        static public Image background = Image.FromFile("..\\..\\images\\background.jpg");
        static Timer timer = new Timer();
        static BaseObject[] _objs;

        static Game()
        {

        }
        static public void Init(Form form)
        {
            Graphics g;
            context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = context.Allocate(g, new Rectangle(0, 0, Width, Height));
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            Load();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
           
        }

        static public void Load()
        {
            _objs = new BaseObject[30];
            for (int i = 0; i < _objs.Length/2; i++)
            {
                _objs[i] = new BaseObject(new Point(600, i * 20), new Point(15 - i, 15 - i), new Size(20, 20));
            }
            for (int i = 15; i < _objs.Length; i++)
            {
                _objs[i] = new Star(new Point(600, i * 20), new Point(-i,0), new Size(20, 20), Color.White);
            }
        }

        static public void Draw()
        {
            //Buffer.Graphics.Clear(Color.Black);
            Buffer.Graphics.DrawImage(background, 0, 0);
            //Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 100, 200, 200));
            //Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100, 100, 200, 200));

            foreach (BaseObject obj in _objs)
            {
                obj.Draw();
            }
            Buffer.Render();
        }

        static public void Update()
        {
            foreach (BaseObject obj in _objs)
            {
                obj.Update();
            }
        }
    }
}
