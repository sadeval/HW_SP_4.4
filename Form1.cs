using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DancingProgressBars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDown.Value;
            flowLayoutPanel.Controls.Clear();

            for (int i = 0; i < count; i++)
            {
                ProgressBar progressBar = new ProgressBar();
                progressBar.Width = 200;
                progressBar.Height = 20;
                flowLayoutPanel.Controls.Add(progressBar);

                StartProgressBar(progressBar);
            }
        }

        private async void StartProgressBar(ProgressBar progressBar)
        {
            progressBar.Value = 0;
            Random random = new Random();
            int duration = random.Next(5, 11);

            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(random.Next(50, 201));

                if (i % 10 == 0) 
                {
                    progressBar.Invoke((MethodInvoker)(() =>
                    {
                        progressBar.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    }));
                }

                progressBar.Invoke((MethodInvoker)(() => progressBar.Value = i));
            }
        }

    }
}
