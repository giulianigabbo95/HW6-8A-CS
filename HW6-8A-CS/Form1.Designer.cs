namespace MyHomework
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecalc = new System.Windows.Forms.Button();
            this.tbTPoint = new System.Windows.Forms.TrackBar();
            this.NbPaths = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NbPoints = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuccessProbability = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTPoint = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCalc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecalc
            // 
            this.btnRecalc.BackColor = System.Drawing.Color.Transparent;
            this.btnRecalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecalc.ForeColor = System.Drawing.Color.Black;
            this.btnRecalc.Location = new System.Drawing.Point(409, 22);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(79, 52);
            this.btnRecalc.TabIndex = 4;
            this.btnRecalc.Text = "Recalc";
            this.btnRecalc.UseVisualStyleBackColor = false;
            this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
            // 
            // tbTPoint
            // 
            this.tbTPoint.BackColor = System.Drawing.Color.Black;
            this.tbTPoint.Location = new System.Drawing.Point(19, 649);
            this.tbTPoint.Maximum = 1000;
            this.tbTPoint.Minimum = 1;
            this.tbTPoint.Name = "tbTPoint";
            this.tbTPoint.Size = new System.Drawing.Size(1179, 45);
            this.tbTPoint.TabIndex = 7;
            this.tbTPoint.TickFrequency = 10;
            this.tbTPoint.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTPoint.Value = 500;
            this.tbTPoint.ValueChanged += new System.EventHandler(this.tbTPoint_ValueChanged);
            // 
            // NbPaths
            // 
            this.NbPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbPaths.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NbPaths.Location = new System.Drawing.Point(83, 21);
            this.NbPaths.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbPaths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbPaths.Name = "NbPaths";
            this.NbPaths.Size = new System.Drawing.Size(96, 23);
            this.NbPaths.TabIndex = 17;
            this.NbPaths.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NbPaths.ValueChanged += new System.EventHandler(this.NbPaths_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "m (Paths)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "n (Points)";
            // 
            // NbPoints
            // 
            this.NbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbPoints.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NbPoints.Location = new System.Drawing.Point(83, 50);
            this.NbPoints.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NbPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbPoints.Name = "NbPoints";
            this.NbPoints.Size = new System.Drawing.Size(96, 23);
            this.NbPoints.TabIndex = 20;
            this.NbPoints.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NbPoints.ValueChanged += new System.EventHandler(this.NbPoints_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(200, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "p (Success Probabilty)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(200, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Frequency";
            // 
            // SuccessProbability
            // 
            this.SuccessProbability.DecimalPlaces = 2;
            this.SuccessProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessProbability.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.SuccessProbability.Location = new System.Drawing.Point(324, 22);
            this.SuccessProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SuccessProbability.Name = "SuccessProbability";
            this.SuccessProbability.Size = new System.Drawing.Size(69, 23);
            this.SuccessProbability.TabIndex = 22;
            this.SuccessProbability.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SuccessProbability.ValueChanged += new System.EventHandler(this.SuccessProbability_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "T Point";
            // 
            // lblTPoint
            // 
            this.lblTPoint.AutoSize = true;
            this.lblTPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPoint.ForeColor = System.Drawing.Color.Black;
            this.lblTPoint.Location = new System.Drawing.Point(79, 100);
            this.lblTPoint.Name = "lblTPoint";
            this.lblTPoint.Size = new System.Drawing.Size(14, 13);
            this.lblTPoint.TabIndex = 33;
            this.lblTPoint.Text = "_";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(19, 127);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1179, 516);
            this.MainPanel.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(817, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "You can move the chart inside the viewport or resize it using bottom-right corner" +
    "";
            // 
            // cmbCalc
            // 
            this.cmbCalc.FormattingEnabled = true;
            this.cmbCalc.Items.AddRange(new object[] {
            "Relative Frequency",
            "Absolute Frequency",
            "Relative Frequency Std",
            "Normalized Sum"});
            this.cmbCalc.Location = new System.Drawing.Point(263, 52);
            this.cmbCalc.Name = "cmbCalc";
            this.cmbCalc.Size = new System.Drawing.Size(130, 21);
            this.cmbCalc.TabIndex = 35;
            this.cmbCalc.SelectedIndexChanged += new System.EventHandler(this.cmbCalc_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1219, 732);
            this.Controls.Add(this.cmbCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.lblTPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SuccessProbability);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NbPoints);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NbPaths);
            this.Controls.Add(this.tbTPoint);
            this.Controls.Add(this.btnRecalc);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Bernoulli Process";
            ((System.ComponentModel.ISupportInitialize)(this.tbTPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.TrackBar tbTPoint;
        private System.Windows.Forms.NumericUpDown NbPaths;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NbPoints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown SuccessProbability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTPoint;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCalc;
    }
}

