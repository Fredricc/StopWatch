namespace StopWatch
{
    partial class StopWatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMin = new Label();
            lblSc = new Label();
            lblCs = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblMin.Location = new Point(99, 34);
            lblMin.Margin = new Padding(4, 0, 4, 0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(90, 65);
            lblMin.TabIndex = 0;
            lblMin.Text = "00:";
            // 
            // lblSc
            // 
            lblSc.AutoSize = true;
            lblSc.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblSc.Location = new Point(181, 34);
            lblSc.Margin = new Padding(4, 0, 4, 0);
            lblSc.Name = "lblSc";
            lblSc.Size = new Size(90, 65);
            lblSc.TabIndex = 1;
            lblSc.Text = "00:";
            // 
            // lblCs
            // 
            lblCs.AutoSize = true;
            lblCs.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblCs.Location = new Point(259, 34);
            lblCs.Margin = new Padding(4, 0, 4, 0);
            lblCs.Name = "lblCs";
            lblCs.Size = new Size(80, 65);
            lblCs.TabIndex = 2;
            lblCs.Text = "00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(77, 140);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(96, 60);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(181, 140);
            btnStop.Margin = new Padding(4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(96, 60);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(285, 140);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 60);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(545, 538);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblCs);
            Controls.Add(lblSc);
            Controls.Add(lblMin);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Blue;
            Margin = new Padding(4);
            Name = "StopWatch";
            Text = "StopWatch";
            Load += StopWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMin;
        private Label lblSc;
        private Label lblCs;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer timer1;
    }
}