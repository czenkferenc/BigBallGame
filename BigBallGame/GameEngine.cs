using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBallGame
{
    class GameEngine
    {
        private static bool finished = false;
        List<Ball> AllBalls = new List<Ball>();

        public void InitializeGame(PictureBox pb, int regular, int monster, int repelent)
        {
            CreateBalls(pb, 0, regular);
            CreateBalls(pb, 1, monster);
            CreateBalls(pb, 2, repelent);
        }

        private void CreateBalls(PictureBox pb, int type, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Ball NewBall = new Ball(pb, type);
                AllBalls.Add(NewBall);
            }
        }

        public void MoveAllBalls(PictureBox pb)
        {
            foreach(Ball b in AllBalls)
            {
                b.MoveBall(pb);
            }
        }
    }
}
