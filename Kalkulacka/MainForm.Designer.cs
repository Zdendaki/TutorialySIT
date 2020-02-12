namespace Kalkulacka
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.Label();
            this.N1 = new NonSelectableButton();
            this.N2 = new NonSelectableButton();
            this.N3 = new NonSelectableButton();
            this.Plus = new NonSelectableButton();
            this.Minus = new NonSelectableButton();
            this.N6 = new NonSelectableButton();
            this.N5 = new NonSelectableButton();
            this.N4 = new NonSelectableButton();
            this.N9 = new NonSelectableButton();
            this.N8 = new NonSelectableButton();
            this.N7 = new NonSelectableButton();
            this.Dot = new NonSelectableButton();
            this.DoubleZero = new NonSelectableButton();
            this.Zero = new NonSelectableButton();
            this.Multiply = new NonSelectableButton();
            this.Percent = new NonSelectableButton();
            this.Equal = new NonSelectableButton();
            this.Divide = new NonSelectableButton();
            this.Sqrt = new NonSelectableButton();
            this.Clear = new NonSelectableButton();
            this.MemAdd = new NonSelectableButton();
            this.MemRead = new NonSelectableButton();
            this.MemClear = new NonSelectableButton();
            this.AllClear = new NonSelectableButton();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Display.Location = new System.Drawing.Point(12, 9);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(274, 40);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // N1
            // 
            this.N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N1.Location = new System.Drawing.Point(12, 227);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(50, 50);
            this.N1.TabIndex = 1;
            this.N1.Text = "1";
            this.N1.UseVisualStyleBackColor = true;
            this.N1.Click += new System.EventHandler(this.Number_Click);
            // 
            // N2
            // 
            this.N2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N2.Location = new System.Drawing.Point(68, 227);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(50, 50);
            this.N2.TabIndex = 2;
            this.N2.Text = "2";
            this.N2.UseVisualStyleBackColor = true;
            this.N2.Click += new System.EventHandler(this.Number_Click);
            // 
            // N3
            // 
            this.N3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N3.Location = new System.Drawing.Point(124, 227);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(50, 50);
            this.N3.TabIndex = 3;
            this.N3.Text = "3";
            this.N3.UseVisualStyleBackColor = true;
            this.N3.Click += new System.EventHandler(this.Number_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Plus.Location = new System.Drawing.Point(180, 227);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 106);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Minus.Location = new System.Drawing.Point(236, 227);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 50);
            this.Minus.TabIndex = 5;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // N6
            // 
            this.N6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N6.Location = new System.Drawing.Point(124, 171);
            this.N6.Name = "N6";
            this.N6.Size = new System.Drawing.Size(50, 50);
            this.N6.TabIndex = 8;
            this.N6.Text = "6";
            this.N6.UseVisualStyleBackColor = true;
            this.N6.Click += new System.EventHandler(this.Number_Click);
            // 
            // N5
            // 
            this.N5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N5.Location = new System.Drawing.Point(68, 171);
            this.N5.Name = "N5";
            this.N5.Size = new System.Drawing.Size(50, 50);
            this.N5.TabIndex = 7;
            this.N5.Text = "5";
            this.N5.UseVisualStyleBackColor = true;
            this.N5.Click += new System.EventHandler(this.Number_Click);
            // 
            // N4
            // 
            this.N4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N4.Location = new System.Drawing.Point(12, 171);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(50, 50);
            this.N4.TabIndex = 6;
            this.N4.Text = "4";
            this.N4.UseVisualStyleBackColor = true;
            this.N4.Click += new System.EventHandler(this.Number_Click);
            // 
            // N9
            // 
            this.N9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N9.Location = new System.Drawing.Point(124, 115);
            this.N9.Name = "N9";
            this.N9.Size = new System.Drawing.Size(50, 50);
            this.N9.TabIndex = 11;
            this.N9.Text = "9";
            this.N9.UseVisualStyleBackColor = true;
            this.N9.Click += new System.EventHandler(this.Number_Click);
            // 
            // N8
            // 
            this.N8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N8.Location = new System.Drawing.Point(68, 115);
            this.N8.Name = "N8";
            this.N8.Size = new System.Drawing.Size(50, 50);
            this.N8.TabIndex = 10;
            this.N8.Text = "8";
            this.N8.UseVisualStyleBackColor = true;
            this.N8.Click += new System.EventHandler(this.Number_Click);
            // 
            // N7
            // 
            this.N7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.N7.Location = new System.Drawing.Point(12, 115);
            this.N7.Name = "N7";
            this.N7.Size = new System.Drawing.Size(50, 50);
            this.N7.TabIndex = 9;
            this.N7.Text = "7";
            this.N7.UseVisualStyleBackColor = true;
            this.N7.Click += new System.EventHandler(this.Number_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dot.Location = new System.Drawing.Point(124, 283);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(50, 50);
            this.Dot.TabIndex = 14;
            this.Dot.Text = "•";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // DoubleZero
            // 
            this.DoubleZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoubleZero.Location = new System.Drawing.Point(68, 283);
            this.DoubleZero.Name = "DoubleZero";
            this.DoubleZero.Size = new System.Drawing.Size(50, 50);
            this.DoubleZero.TabIndex = 13;
            this.DoubleZero.Text = "00";
            this.DoubleZero.UseVisualStyleBackColor = true;
            this.DoubleZero.Click += new System.EventHandler(this.Number_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zero.Location = new System.Drawing.Point(12, 283);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(50, 50);
            this.Zero.TabIndex = 12;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Number_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Multiply.Location = new System.Drawing.Point(180, 171);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 50);
            this.Multiply.TabIndex = 15;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Percent
            // 
            this.Percent.Enabled = false;
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Percent.Location = new System.Drawing.Point(180, 115);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(50, 50);
            this.Percent.TabIndex = 16;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Equal.Location = new System.Drawing.Point(236, 283);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(50, 50);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Divide.Location = new System.Drawing.Point(236, 171);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 18;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sqrt.Location = new System.Drawing.Point(236, 115);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(50, 50);
            this.Sqrt.TabIndex = 19;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clear.Location = new System.Drawing.Point(180, 59);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(50, 50);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MemAdd
            // 
            this.MemAdd.Enabled = false;
            this.MemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MemAdd.Location = new System.Drawing.Point(12, 60);
            this.MemAdd.Name = "MemAdd";
            this.MemAdd.Size = new System.Drawing.Size(50, 50);
            this.MemAdd.TabIndex = 21;
            this.MemAdd.Text = "M+";
            this.MemAdd.UseVisualStyleBackColor = true;
            // 
            // MemRead
            // 
            this.MemRead.Enabled = false;
            this.MemRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MemRead.Location = new System.Drawing.Point(68, 60);
            this.MemRead.Name = "MemRead";
            this.MemRead.Size = new System.Drawing.Size(50, 50);
            this.MemRead.TabIndex = 23;
            this.MemRead.Text = "MR";
            this.MemRead.UseVisualStyleBackColor = true;
            // 
            // MemClear
            // 
            this.MemClear.Enabled = false;
            this.MemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MemClear.Location = new System.Drawing.Point(124, 60);
            this.MemClear.Name = "MemClear";
            this.MemClear.Size = new System.Drawing.Size(50, 50);
            this.MemClear.TabIndex = 24;
            this.MemClear.Text = "MC";
            this.MemClear.UseVisualStyleBackColor = true;
            // 
            // AllClear
            // 
            this.AllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AllClear.Location = new System.Drawing.Point(236, 59);
            this.AllClear.Name = "AllClear";
            this.AllClear.Size = new System.Drawing.Size(50, 50);
            this.AllClear.TabIndex = 25;
            this.AllClear.Text = "AC";
            this.AllClear.UseVisualStyleBackColor = true;
            this.AllClear.Click += new System.EventHandler(this.AllClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 345);
            this.Controls.Add(this.AllClear);
            this.Controls.Add(this.MemClear);
            this.Controls.Add(this.MemRead);
            this.Controls.Add(this.MemAdd);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.DoubleZero);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.N9);
            this.Controls.Add(this.N8);
            this.Controls.Add(this.N7);
            this.Controls.Add(this.N6);
            this.Controls.Add(this.N5);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kalkulačka";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private NonSelectableButton N1;
        private NonSelectableButton N2;
        private NonSelectableButton N3;
        private NonSelectableButton Plus;
        private NonSelectableButton Minus;
        private NonSelectableButton N6;
        private NonSelectableButton N5;
        private NonSelectableButton N4;
        private NonSelectableButton N9;
        private NonSelectableButton N8;
        private NonSelectableButton N7;
        private NonSelectableButton Dot;
        private NonSelectableButton DoubleZero;
        private NonSelectableButton Zero;
        private NonSelectableButton Multiply;
        private NonSelectableButton Percent;
        private NonSelectableButton Equal;
        private NonSelectableButton Divide;
        private NonSelectableButton Sqrt;
        private NonSelectableButton Clear;
        private NonSelectableButton MemAdd;
        private NonSelectableButton MemRead;
        private NonSelectableButton MemClear;
        private NonSelectableButton AllClear;
    }
}

