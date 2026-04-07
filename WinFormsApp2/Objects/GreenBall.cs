using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp2.Objects
{
    class GreenBall : BaseObject
    {
        public Random rnd = new Random();
        public int widthForm;
        public int heightForm;

        public GreenBall(float x, float y, float angle, int width, int height) : base(x, y, angle)
        {
            widthForm = width;
            heightForm = height;
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

        public void Respawn()
        {
            X = rnd.Next(50, widthForm - 50);
            Y = rnd.Next(50, heightForm - 50);
        }
    }
}