using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp2.Objects
{
    class GreenBall : BaseObject
    {
        public Random rnd = new Random();

        public GreenBall(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.LimeGreen), -15, -15, 30, 30);
            g.DrawEllipse(new Pen(Color.DarkGreen, 2), -15, -15, 30, 30);
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-15, -15, 30, 30);
            return path;
        }
    }
}