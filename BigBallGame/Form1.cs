using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBallGame
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics grp;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pb.Width, pb.Height);
            grp = Graphics.FromImage(bmp);
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {

            GameEngine.InitializeGame(pb, (int)numericUpDown_Regular.Value,
                        (int)numericUpDown_Monster.Value, (int)numericUpDown_Repelent.Value);
            timer1.Interval = (int)numericUpDown_Tick.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!GameEngine.Finished)
            {
                GameEngine.DrawBalls(grp);
                GameEngine.Turn(pb);
                pb.Image = bmp;
                pb.Refresh();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("game over");
            }
        }
    }
}
