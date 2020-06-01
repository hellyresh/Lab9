using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab9_Circles
{
    public partial class Paint : Form
    {
        private System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public static int counter = 0;
        private readonly object balanceLock = new object();
        public Paint()
        {
            InitializeComponent();
            t.Interval = 100;
            t.Tick += new EventHandler(tTick);
        }

        private void start_Click(object sender, EventArgs e)
        {

            t.Enabled = true;
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
        }

        private void tTick(object sender, EventArgs e)
        {
            lock (balanceLock)
            {
                if (counter < int.Parse(maxCnt.Text))
                {
                    counter++;
                    Thread t = new Thread(new ThreadStart(new Circle(int.Parse(liveTime.Text), drawBox.CreateGraphics(), drawBox.Width, drawBox.Height).Run));
                    t.Start();
                }
            }
        }
    }
}
