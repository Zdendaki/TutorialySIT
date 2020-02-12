using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class MainForm : Form
    {
        string NumberInput { 
            get
            {
                return Display.Text;
            }
            set
            {
                Display.Text = value;
            }
        }
        bool IsMinus = false;
        Operation Current = Operation.None;
        Calculator Calc;
        bool NewStep = false;
        NumberFormatInfo NFI;


        public MainForm()
        {
            InitializeComponent();

            NFI = new NumberFormatInfo();
            NFI.NumberDecimalSeparator = ".";

            Calc = new Calculator();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (NewStep)
            {
                NumberInput = null;
                NewStep = false;
            }
            
            Control c = (Control)sender;

            if (c.Text == "00" && NumberInput.Length >= 17)
                return;

            if (NumberInput.Length == 18)
                return;

            NumberInput += c.Text;

            if (NumberInput.Length > 1)
                NumberInput = NumberInput.TrimStart(new[] { '0' });

            if (NumberInput.Length == 0 || NumberInput[0] == '.')
                NumberInput = "0" + NumberInput;

            if (IsMinus && !NumberInput.Contains("-"))
            {
                NumberInput = "-" + NumberInput;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;

            if (!NumberInput.Contains(".") && NumberInput.Length < 18)
                NumberInput += ".";
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (Current == Operation.None)
                Calc.AddOperation(double.Parse(NumberInput, NFI), Operation.Add);
            else
                Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

            Current = Operation.Add;
            NewStep = true;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (Current == Operation.None)
                Calc.AddOperation(double.Parse(NumberInput, NFI), Operation.Add);
            else
                Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

            Current = Operation.Multiply;
            NewStep = true;
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            if (Current == Operation.None)
                Calc.AddOperation(double.Parse(NumberInput, NFI), Operation.Add);
            else
                Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

            Current = Operation.Percent;
            NewStep = true;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Current == Operation.None)
                Calc.AddOperation(double.Parse(NumberInput, NFI), Operation.Add);
            else
                Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

            Current = Operation.SquareRoot;
            Equal_Click(this, null);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (Current == Operation.None)
                Calc.AddOperation(double.Parse(NumberInput, NFI), Operation.Add);
            else
                Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

            Current = Operation.Divide;
            NewStep = true;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            IsMinus = NumberInput == "0";

            if (!IsMinus)
            {
                if (Current == Operation.None)
                    Calc.AddOperation(double.Parse(NumberInput, NFI), Operation.Add);
                else
                    Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

                Current = Operation.Substract;
                NewStep = true;
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (Current != Operation.None)
                Calc.AddOperation(double.Parse(NumberInput, NFI), Current);

            NumberInput = Calc.ComputeOperations().ToString(NFI);

            Current = Operation.None;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            

            if (char.IsDigit(c))
            {
                Control x = new Control();
                x.Text = c.ToString();

                Number_Click(x, new EventArgs());
            }
            else if (c == '*')
            {
                Multiply_Click(this, null);
            }
            else if (c == '-')
            {
                Minus_Click(this, null);
            }
            else if (c == '/')
            {
                Divide_Click(this, null);
            }
            else if (c == '+')
            {
                Plus_Click(this, null);
            }
            else if (c == '=' || e.KeyChar == (char)Keys.Enter)
            {
                Equal_Click(this, null);
            }
            else if (c == '.' || c == ',')
            {
                Dot_Click(this, null);
            }
            else if (c == (char)Keys.Back)
            {
                Clear_Click(this, null);
            }
            else if (c == (char)Keys.Escape)
            {
                AllClear_Click(this, null);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NumberInput = "0";
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            NumberInput = "0";
            Current = Operation.None;
            Calc.ClearOperations();
        }
    }
}
