using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp2.Objects
{
    class RedCircle : BaseObject
    {
        public Random rnd = new Random();
        public int size = 10;

        public RedCircle(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            size += 1;
            g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), -size, -size, size * 2, size * 2);
            g.DrawEllipse(new Pen(Color.Red, 2), -size, -size, size * 2, size * 2);
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-size, -size, size * 2, size * 2);
            return path;
        }
    }
}