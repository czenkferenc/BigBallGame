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
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            Graphics grp = Graphics.FromImage(bmp);
            Ball a = new Ball(pb);
            bool finished = false;
            while(!finished)
            {
                grp.Clear(Color.White);
                SolidBrush b = new SolidBrush(a.Color);
                grp.FillEllipse(b, a.Position.X - a.Radius, a.Position.Y - a.Radius, a.Radius * 2, a.Radius * 2);
                a.MoveBall(pb);
                pb.Image = bmp;
                pb.Refresh();
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
