using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp2.Objects
{
    class RedCircle : BaseObject
    {
        public Random rnd = new Random();
        public int widthForm;
        public int heightForm;
        public int size = 10;

        public RedCircle(float x, float y, float angle, int width, int height) : base(x, y, angle)
        {
            widthForm = width;
            heightForm = height;
        }

        public override void Render(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 255, 0, 0)))
            {
                g.FillEllipse(brush, -size, -size, size * 2, size * 2);
            }
            g.DrawEllipse(new Pen(Color.Red, 2), -size, -size, size * 2, size * 2);
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-size, -size, size * 2, size * 2);
            return path;
        }

        public void Respawn()
        {
            X = rnd.Next(50, widthForm - 50);
            Y = rnd.Next(50, heightForm - 50);
            size = 10;
        }

        public void IncreaseSize()
        {
            size += 1;
        }
    }
}