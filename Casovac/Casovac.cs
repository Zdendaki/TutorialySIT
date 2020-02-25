using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casovac
{
    public partial class Casovac : Form
    {
        Limits TimeLimits;
        DateTime StartTime;
        bool Started = false;

        public Casovac()
        {
            InitializeComponent();
            TimeLimits = new Limits();

            Total.Text = NextPart.Text = CurrentPart.Text = null;
        }

        private void ProgressBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            double totalseconds = TimeLimits.TimeLimits.Sum(x => x.Time.TotalSeconds);

            float last = 0;
            foreach (TimeLimit l in TimeLimits.TimeLimits)
            {
                float width = (float)(l.Time.TotalSeconds * ProgressBar.Width / totalseconds);

                g.FillRectangle(new SolidBrush(l.Color), new RectangleF(last, 0, width, ProgressBar.Height));

                last += width;
            }

            if (Started)
            {
                TimeSpan current = DateTime.Now - StartTime;
                float width = (float)(current.TotalSeconds * ProgressBar.Width / totalseconds);
                g.FillRectangle(Brushes.Black, new RectangleF(0, ProgressBar.Height - 10, width, 10));
            }
        }

        private void ProgressBar_Resize(object sender, EventArgs e)
        {
            ProgressBar.Invalidate();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan current = DateTime.Now - StartTime;
            
            if (Started)
            {
                Total.Text = TimeSpan.FromSeconds(TimeLimits.TimeLimits.Sum(x => x.Time.TotalSeconds)).ToString(@"m\:ss");
                NextPart.Text = TimeLimits.TimeToPartEnd(current).ToString(@"m\:ss");
                CurrentPart.Text = TimeLimits.GetCurrentPart(current).Name;

                ProgressBar.Invalidate();
            }
            else
            {
                Total.Text = NextPart.Text = null;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartTime = DateTime.Now;
            Started = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Started = false;
            ProgressBar.Invalidate();
        }
    }
}
