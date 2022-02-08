using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework
{
    public partial class Form1 : Form
    {
        private int m;           // number of paths
        private int n;           // number of points for each path
        private double p;        // success probability
        private int t;           // point at time T

        private Bernoulli bernoulli;

        private ggPictureBox ggPictureBox1;

        private int pixelAdj = 0;

        public Form1()
        {
            InitializeComponent();

            ggPictureBox1 = new ggPictureBox(MainPanel);
            ggPictureBox1.BackColor = Color.White;
            ggPictureBox1.Top = MainPanel.Height / 10; ;
            ggPictureBox1.Left = MainPanel.Left + MainPanel.Width / 10;
            ggPictureBox1.Height = MainPanel.Height / 10 * 8;
            ggPictureBox1.Width = MainPanel.Width / 10 * 8;
            ggPictureBox1.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(ggPictureBox1);

            tbTPoint.Minimum = 1;
            tbTPoint.Maximum = (int)NbPoints.Value;
            tbTPoint.Value = (int)Math.Ceiling((double)NbPoints.Value / 2);
            tbTPoint.TickFrequency = tbTPoint.Maximum / 10;

            cmbCalc.SelectedIndex = 0;

            SetVariables();
        }

        // Events
        //--------------------------------------------------------

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            SetVariables();

            tbTPoint.Minimum = 1;
            tbTPoint.Maximum = n;

            CreateBernoulliInstance();
            DrawChart();
        }

        private void NbPaths_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateBernoulliInstance();
            DrawChart();
        }

        private void NbPoints_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();

            tbTPoint.Maximum = n;
            t = tbTPoint.Value = (int)Math.Ceiling((double)n / 2);
            tbTPoint.TickFrequency = tbTPoint.Maximum / 10;

            CreateBernoulliInstance();
            DrawChart();
        }

        private void SuccessProbability_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateBernoulliInstance();
            DrawChart();
        }

        private void EpsilonValue_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateBernoulliInstance();
            DrawChart();
        }

        private void tbTPoint_ValueChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateBernoulliInstance();
            DrawChart();
        }

        private void cmbCalc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetVariables();
            CreateBernoulliInstance();
            DrawChart();
        }

        // Methods
        //--------------------------------------------------------

        private void SetVariables()
        {
            m = (int)NbPaths.Value;
            n = (int)NbPoints.Value;
            p = (double)SuccessProbability.Value / (double)SuccessProbability.Maximum;
            t = tbTPoint.Value;

            switch (cmbCalc.SelectedIndex)
            {
                case 1:
                    pixelAdj = 0;
                    break;
                case 2:
                    pixelAdj = ggPictureBox1.Height / 2;    // la distribzione contiene anche valori negativi. è necessario innalzare l'asse X = 0 al centro della picture box
                    break;
                case 3:
                    pixelAdj = 0;
                    break;
                default:
                    pixelAdj = 0;
                    break;
            }

            lblTPoint.Text = t.ToString();
        }

        private void CreateBernoulliInstance()
        {
            bernoulli = new Bernoulli(cmbCalc.SelectedIndex, m, n, p, t);
        }

        private void DrawChart()
        {
            ChartManager CM = new ChartManager(bernoulli, ggPictureBox1, MainPanel, pixelAdj);
            CM.DrawChart();
        }
    }
}
