namespace DancingProgressBars
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;

        private void InitializeComponent()
        {
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();

            // numericUpDown
            this.numericUpDown.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown.Minimum = 1;
            this.numericUpDown.Maximum = 20; // Максимальное количество прогресс-баров
            this.numericUpDown.Value = 5;

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(12, 50);
            this.btnStart.Text = "Начать";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // flowLayoutPanel
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 90);
            this.flowLayoutPanel.Size = new System.Drawing.Size(300, 200);
            this.flowLayoutPanel.AutoScroll = true;

            // Form1
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flowLayoutPanel);
            this.ResumeLayout(false);
        }
    }
}
