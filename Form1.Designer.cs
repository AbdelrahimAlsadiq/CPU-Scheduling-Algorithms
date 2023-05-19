namespace Operating_Systems_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AlgorithmsMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.Label();
            this.BurstTime = new System.Windows.Forms.TextBox();
            this.ArrivalTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.currentPocesses = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.QLabel = new System.Windows.Forms.Label();
            this.QValue = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AvgWaiting = new System.Windows.Forms.Label();
            this.TurnAround = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AlgorithmsMenu
            // 
            this.AlgorithmsMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgorithmsMenu.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlgorithmsMenu.Items.AddRange(new object[] {
            "First Come First Serve (FCFS)",
            "Preemptive Shortest Job First (pSJF)",
            "Non Preemptive Shortest Job First (npSJF)",
            "Robin Round (RR)"});
            this.AlgorithmsMenu.Location = new System.Drawing.Point(271, 38);
            this.AlgorithmsMenu.Name = "AlgorithmsMenu";
            this.AlgorithmsMenu.Size = new System.Drawing.Size(395, 34);
            this.AlgorithmsMenu.TabIndex = 2;
            this.AlgorithmsMenu.SelectedIndexChanged += new System.EventHandler(this.AlgorithmsMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Manrope Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Manrope Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Import Processes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.AutoSize = true;
            this.ProcessName.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcessName.Location = new System.Drawing.Point(8, 62);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(38, 26);
            this.ProcessName.TabIndex = 4;
            this.ProcessName.Text = "P1:";
            // 
            // BurstTime
            // 
            this.BurstTime.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BurstTime.Location = new System.Drawing.Point(205, 112);
            this.BurstTime.Name = "BurstTime";
            this.BurstTime.Size = new System.Drawing.Size(271, 40);
            this.BurstTime.TabIndex = 2;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArrivalTime.Location = new System.Drawing.Point(205, 55);
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Size = new System.Drawing.Size(271, 40);
            this.ArrivalTime.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Burst Time:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(265, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Manrope Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Processes in Queue:";
            // 
            // currentPocesses
            // 
            this.currentPocesses.AutoSize = true;
            this.currentPocesses.Font = new System.Drawing.Font("Manrope", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPocesses.Location = new System.Drawing.Point(11, 320);
            this.currentPocesses.Name = "currentPocesses";
            this.currentPocesses.Size = new System.Drawing.Size(0, 19);
            this.currentPocesses.TabIndex = 8;
            this.currentPocesses.UseMnemonic = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(373, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ArrivalTime);
            this.panel1.Controls.Add(this.BurstTime);
            this.panel1.Controls.Add(this.ProcessName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 251);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Controls.Add(this.QLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AlgorithmsMenu);
            this.panel2.Controls.Add(this.QValue);
            this.panel2.Location = new System.Drawing.Point(535, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 215);
            this.panel2.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Manrope Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(553, 165);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(148, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Generate";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Manrope Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QLabel.Location = new System.Drawing.Point(40, 104);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(163, 26);
            this.QLabel.TabIndex = 1;
            this.QLabel.Text = "Quantam Value:";
            this.QLabel.Visible = false;
            // 
            // QValue
            // 
            this.QValue.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QValue.Location = new System.Drawing.Point(271, 93);
            this.QValue.Name = "QValue";
            this.QValue.Size = new System.Drawing.Size(243, 40);
            this.QValue.TabIndex = 2;
            this.QValue.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(535, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 224);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(535, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average Waiting Time (ms):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(535, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Average Turnaround Time (ms):";
            // 
            // AvgWaiting
            // 
            this.AvgWaiting.AutoSize = true;
            this.AvgWaiting.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvgWaiting.Location = new System.Drawing.Point(806, 505);
            this.AvgWaiting.Name = "AvgWaiting";
            this.AvgWaiting.Size = new System.Drawing.Size(20, 22);
            this.AvgWaiting.TabIndex = 6;
            this.AvgWaiting.Text = "0";
            // 
            // TurnAround
            // 
            this.TurnAround.AutoSize = true;
            this.TurnAround.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnAround.Location = new System.Drawing.Point(806, 539);
            this.TurnAround.Name = "TurnAround";
            this.TurnAround.Size = new System.Drawing.Size(20, 22);
            this.TurnAround.TabIndex = 0;
            this.TurnAround.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Manrope Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(535, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gantt Chart:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Manrope", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 8;
            this.label9.UseMnemonic = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Operating_Systems_Project.Properties.Resources.صورة_واتساب_بتاريخ_2023_03_14_في_17_56_22;
            this.pictureBox1.Location = new System.Drawing.Point(384, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TurnAround);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AvgWaiting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.currentPocesses);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operating Systems Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox AlgorithmsMenu;
        private Label label1;
        private Label label2;
        private Label ProcessName;
        private TextBox BurstTime;
        private TextBox ArrivalTime;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label currentPocesses;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label7;
        private Button startButton;
        private Label AvgWaiting;
        private Label TurnAround;
        private Label label8;
        private Label label9;
        private Label QLabel;
        private TextBox QValue;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
    }
}