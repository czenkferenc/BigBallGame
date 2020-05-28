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
        private static List<Ball> AllBalls = new List<Ball>();

        public static void InitializeGame(PictureBox pb, int regular, int monster, int repelent)
        {
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
            for (int i = 0; i < AllBalls.Count; i++)
            {
                for (int j = i; j < AllBalls.Count; j++)
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
                    if(a.Type == "monster")
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
                    if(a.Type == "repelent")
                    {
                        a.GetColor(b);
                        b.ChangeDirection();
                    }
                    else
                    {
                        b.GetColor(a);
                        a.ChangeDirection();
                    }
                    break;
                case 3:
                    a.SwapColors(b);
                    break;
                case 4:
                    if(a.Type == "repelent")
                    {
                        if(a.Radius < 2)
                        {
                            AllBalls.Remove(a);
                        }
                        else
                        {
                            a.DecreaseRadius();
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
            if (a.Type == "regular" && b.Type == "regular") return 0;
            else if ((a.Type == "regular" && b.Type == "monster") || (a.Type == "monster" && b.Type == "regular")) return 1;
            else if ((a.Type == "regular" && b.Type == "repelent") || (a.Type == "repelent" && b.Type == "regular")) return 2;
            else if (a.Type == "repelent" && b.Type == "repelent") return 3;
            else if ((a.Type == "repelent" && b.Type == "monster") || (a.Type == "monster" && b.Type == "repelent")) return 4;
            else return 5;
            
        }
    }
}
