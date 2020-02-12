using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenerCrypt
{
    public partial class MainForm : Form
    {
        Vigener Vigener;
        
        public MainForm()
        {
            InitializeComponent();

            Vigener = new Vigener();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Vigener.Characters.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OutputBox_DoubleClick(object sender, EventArgs e)
        {
            OutputBox.SelectionStart = 0;
            OutputBox.SelectionLength = OutputBox.TextLength;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            OutputBox.Text = Vigener.Encrypt(InputBox.Text, PasswordBox.Text);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            OutputBox.Text = Vigener.Decrypt(InputBox.Text, PasswordBox.Text);
        }
    }
}
