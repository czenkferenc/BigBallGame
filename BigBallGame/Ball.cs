using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBallGame
{
    class Ball
    {
        private static int radius;
        private static Point position;
        private static Color color;
        private static int dx;
        private static int dy;
        private static string type;

        public Ball(PictureBox pb)
        {
            Random r = new Random();
            radius = r.Next(7, 21);
            position = new Point(r.Next(0 + radius, pb.Width - radius), r.Next(0 + radius, pb.Height - radius));
            color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            dx = r.Next(-5, 5);
            dy = r.Next(-5, 5);
            int tmpType = r.Next(3);
            if (tmpType == 0) type = "regular";
            if (tmpType == 1) type = "monster";
            if (tmpType == 2) type = "repelent";
            if (type == "monster")
            {
                dx = 0;
                dy = 0;
            }
        }

        public Ball(PictureBox pb, int tmpType)
        {
            Random r = new Random();
            radius = r.Next(7, 21);
            position = new Point(r.Next(0 + radius, pb.Width - radius), r.Next(0 + radius, pb.Height - radius));
            color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            dx = r.Next(-5, 5);
            dy = r.Next(-5, 5);
            if (0 <= tmpType && tmpType <= 2)
            {
                if (tmpType == 0) type = "regular";
                if (tmpType == 1) type = "monster";
                if (tmpType == 2) type = "repelent";
            }
            else
            {
                int tmpType2 = r.Next(3);
                if (tmpType2 == 0) type = "regular";
                if (tmpType2 == 1) type = "monster";
                if (tmpType2 == 2) type = "repelent";
            }
            if(type == "monster")
            {
                dx = 0;
                dy = 0;
            }
        }

        public Color Color
        {
            get { return color; }
            private set { color = value; }
        }

        public Point Position
        {
            get { return position; }
        }

        public int Radius
        {
            get { return radius; }
        }

        public string Type
        {
            get { return type; }
        }

        public void MoveBall(PictureBox pb)
        {
            if (!HitEdge(pb))
            {
                position.X += dx;
                position.Y += dy;
            }
            else
            {
                if (position.X + radius >= pb.Width) dx *= -1;
                if (position.Y + radius >= pb.Height) dy *= -1;
                if (position.X - radius <= 0) dx *= -1;
                if (position.Y - radius <= 0) dy *= -1;
                position.X += dx;
                position.Y += dy;
            }
        }

        private static bool HitEdge(PictureBox pb)
        {
            if (position.X + radius >= pb.Width || position.Y + radius >= pb.Height || position.X - radius <= 0 || position.Y - radius <= 0)
                return true;
            else
                return false;
        }

        public void IncreaseRadius(Ball b)
        {
            radius += b.Radius;
        }

        public void DecreaseRadius()
        {
            radius /= 2;
        }

        public void ChangeColor(Ball b)
        {
            int R = (color.R * radius + b.Color.R * b.Radius) / radius + b.Radius;
            int G = (color.G * radius + b.Color.G * b.Radius) / radius + b.Radius;
            int B = (color.B * radius + b.Color.B * b.Radius) / radius + b.Radius;

            Color newColor = Color.FromArgb(R, G, B);
            color = newColor;
        }

        public void GetColor(Ball b)
        {
            color = b.Color;
        }

        public void ChangeDirection()
        {
            dx *= -1;
            dy *= -1;
        }

        public void SwapColors(Ball b)
        {
            Color auxColor = color;
            color = b.Color;
            b.Color = auxColor;
        }
    }
}
