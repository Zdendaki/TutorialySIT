namespace Casovac
{
    partial class Casovac
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
            this.components = new System.ComponentModel.Container();
            this.ProgressBar = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.NextPart = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentPart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgressBar.Location = new System.Drawing.Point(12, 12);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(760, 50);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.TabStop = false;
            this.ProgressBar.SizeChanged += new System.EventHandler(this.ProgressBar_Resize);
            this.ProgressBar.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressBar_Paint);
            this.ProgressBar.Resize += new System.EventHandler(this.ProgressBar_Resize);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(672, 68);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 31);
            this.Start.TabIndex = 1;
            this.Start.Text = "Spustit";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(566, 68);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 31);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Zastavit";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celkem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Další část za:";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(54, 1);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(42, 13);
            this.Total.TabIndex = 6;
            this.Total.Text = "TOTAL";
            // 
            // NextPart
            // 
            this.NextPart.AutoSize = true;
            this.NextPart.Location = new System.Drawing.Point(81, 21);
            this.NextPart.Name = "NextPart";
            this.NextPart.Size = new System.Drawing.Size(36, 13);
            this.NextPart.TabIndex = 7;
            this.NextPart.Text = "NEXT";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.CurrentPart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NextPart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 44);
            this.panel1.TabIndex = 8;
            // 
            // CurrentPart
            // 
            this.CurrentPart.AutoSize = true;
            this.CurrentPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentPart.Location = new System.Drawing.Point(139, 1);
            this.CurrentPart.Name = "CurrentPart";
            this.CurrentPart.Size = new System.Drawing.Size(73, 15);
            this.CurrentPart.TabIndex = 8;
            this.CurrentPart.Text = "CURRENT";
            // 
            // Casovac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 111);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ProgressBar);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 150);
            this.Name = "Casovac";
            this.Text = "Časovač";
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProgressBar;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label NextPart;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentPart;
    }
}

