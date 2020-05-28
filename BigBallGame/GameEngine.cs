using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBallGame
{
    class GameEngine
    {
        private static bool finished = false;
        private static int regularCount = 0;
        private static List<Ball> AllBalls;

        public static bool Finished
        {
            get { return finished; }
        }

        public static void InitializeGame(PictureBox pb, int regular, int monster, int repelent)
        {
            AllBalls = new List<Ball>();
            CreateBalls(pb, 0, regular);
            CreateBalls(pb, 1, monster);
            CreateBalls(pb, 2, repelent);
            regularCount = regular;
        }

        private static void CreateBalls(PictureBox pb, int type, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Ball NewBall = new Ball(pb, type);
                AllBalls.Add(NewBall);
            }
        }

        private static void MoveAllBalls(PictureBox pb)
        {
            foreach (Ball b in AllBalls)
            {
                b.MoveBall(pb);
            }
        }

        public static void Turn(PictureBox pb)
        {
            MoveAllBalls(pb);
            CheckCollision();
            if(regularCount == 0)
            {
                finished = true;
            }
        }

        private static void CheckCollision()
        {
            for (int i = 0; i < AllBalls.Count - 1; i++)
            {
                for (int j = i + 1; j < AllBalls.Count; j++)
                {
                    if (IsCollision(AllBalls[i], AllBalls[j]))
                        CollisionLogic(AllBalls[i], AllBalls[j]);
                }
            }
        }

        private static bool IsCollision(Ball a, Ball b)
        {
            if (Distance(a.Position, b.Position) <= a.Radius + b.Radius) return true;
            else return false;
        }

        private static double Distance(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        private static void CollisionLogic(Ball a, Ball b)
        {
            switch (CollisionType(a, b))
            {
                case 0:
                    if (a.Radius <= b.Radius)
                    {
                        b.ChangeColor(a);
                        b.IncreaseRadius(a);
                        AllBalls.Remove(a);
                    }
                    else
                    {
                        a.ChangeColor(b);
                        a.IncreaseRadius(b);
                        AllBalls.Remove(b);
                    }
                    regularCount--;
                    break;
                case 1:
                    if(a.Type == 1)
                    {
                        a.IncreaseRadius(b);
                        AllBalls.Remove(b);
                    }
                    else
                    {
                        b.IncreaseRadius(a);
                        AllBalls.Remove(a);
                    }
                    regularCount--;
                    break;
                case 2:
                    if(a.Type == 2)
                    {
                        a.GetColor(b);
                        a.ChangeDirection();
                        b.ChangeDirection();
                    }
                    else
                    {
                        b.GetColor(a);
                        a.ChangeDirection();
                        b.ChangeDirection();
                    }
                    break;
                case 3:
                    a.SwapColors(b);
                    break;
                case 4:
                    if(a.Type == 2)
                    {
                        if(a.Radius < 2)
                        {
                            AllBalls.Remove(a);
                        }
                        else
                        {
                            a.DecreaseRadius();
                            a.ChangeDirection();
                        }
                    }
                    else
                    {
                        if (a.Radius < 2)
                        {
                            AllBalls.Remove(b);
                        }
                        else
                        {
                            b.DecreaseRadius();
                            b.ChangeDirection();
                        }
                    }
                    break;
                case 5:
                    finished = true;
                    break;
            }
        }

        private static int CollisionType(Ball a, Ball b)
        {
            if (a.Type == 0 && b.Type == 0) return 0;
            else if ((a.Type == 0 && b.Type == 1) || (a.Type == 1 && b.Type == 0)) return 1;
            else if ((a.Type == 0 && b.Type == 2) || (a.Type == 2 && b.Type == 0)) return 2;
            else if (a.Type == 2 && b.Type == 2) return 3;
            else if ((a.Type == 2 && b.Type == 1) || (a.Type == 1 && b.Type == 2)) return 4;
            else return 5;
            
        }

        public static void DrawBalls(Graphics grp)
        {
            grp.Clear(Color.White);
            foreach (Ball b in AllBalls)
            {
                SolidBrush brush = new SolidBrush(b.Color);
                grp.FillEllipse(brush, b.Position.X - b.Radius, b.Position.Y - b.Radius, b.Radius * 2, b.Radius * 2);
            }
        }
    }
}
