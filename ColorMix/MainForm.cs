using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ChangeColor();
        }

        private void Color_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ChangeColor()
        {
            ColorPanel.BackColor = Color.FromArgb(Red.Value, Green.Value, Blue.Value);

            RedLabel.Text = Red.Value.ToString();
            GreenLabel.Text = Green.Value.ToString();
            BlueLabel.Text = Blue.Value.ToString();
        }
    }
}
