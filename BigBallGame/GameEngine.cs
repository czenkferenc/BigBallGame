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
        private static List<Ball> AllBalls = new List<Ball>();

        public static void InitializeGame(PictureBox pb, int regular, int monster, int repelent)
        {
            CreateBalls(pb, 0, regular);
            CreateBalls(pb, 1, monster);
            CreateBalls(pb, 2, repelent);
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
            foreach(Ball b in AllBalls)
            {
                b.MoveBall(pb);
            }
        }

        public static void Turn(PictureBox pb)
        {
            MoveAllBalls(pb);
            CheckCollision();
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

        }
    }
}
