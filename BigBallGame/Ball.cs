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
        private int radius;
        private Point position;
        private Color color;
        private int dx;
        private int dy;
        private int type;
        private static Random r = new Random();
        public Ball(PictureBox pb)
        {

            this.radius = r.Next(3, 11);
            this.position = new Point(r.Next(radius, pb.Width - radius), r.Next(radius, pb.Height - radius));
            this.color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            this.dx = r.Next(-5, 5);
            this.dy = r.Next(-5, 5);
            this.type = r.Next(3);
            if(type == 2)
            {
                this.dx = 0;
                this.dy = 0;
            }
        }

        public Ball(PictureBox pb, int tmpType)
        {
            this.radius = r.Next(7, 21);
            this.position = new Point(r.Next(radius, pb.Width - radius), r.Next(radius, pb.Height - radius));
            this.color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            this.dx = r.Next(-5, 5);
            this.dy = r.Next(-5, 5);
            if (0 <= tmpType && tmpType <= 2)
            {
                this.type = tmpType;
            }
            else
            {
                this.type = r.Next(3);
            }
            if (type == 1)
            {
                this.dx = 0;
                this.dy = 0;
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

        public int Type
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

        private bool HitEdge(PictureBox pb)
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
            int R = (color.R * radius + b.Color.R * b.Radius) / (radius + b.Radius);
            int G = (color.G * radius + b.Color.G * b.Radius) / (radius + b.Radius);
            int B = (color.B * radius + b.Color.B * b.Radius) / (radius + b.Radius);

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
