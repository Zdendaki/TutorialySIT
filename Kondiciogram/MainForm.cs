using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kondiciogram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int life = (int)(today - BirthDate.Value.Date).TotalDays;

            Graph.Series[0].Points.Clear();
            Graph.Series[1].Points.Clear();
            Graph.Series[2].Points.Clear();

            for (int i = -10; i < 30; i++)
            {
                Graph.Series[0].Points.AddXY(DateTime.Today.AddDays(i).ToString("d.M.yyyy"), CountCycle(life + i, 1));
                Graph.Series[1].Points.AddXY(DateTime.Today.AddDays(i).ToString("d.M.yyyy"), CountCycle(life + i, 2));
                Graph.Series[2].Points.AddXY(DateTime.Today.AddDays(i).ToString("d.M.yyyy"), CountCycle(life + i, 3));

                Graph.Annotations[0].Visible = true;
            }
        }

        private double CountCycle(int days, int cycleType)
        {
            if (cycleType == 1) // Fyzický cyklus
            {
                return Math.Sin((days / 23.000) * 2 * Math.PI);
            }
            else if (cycleType == 2) // Psychický cylkus
            {
                return Math.Sin((days / 28.000) * 2 * Math.PI);
            }
            else if (cycleType == 3) // Intelektuální cyklus
            {
                return Math.Sin((days / 33.000) * 2 * Math.PI);
            }

            return 0;
        }
    }
}
