namespace Voting_Server
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameCalon2Label = new System.Windows.Forms.Label();
            this.nameCalon1Label = new System.Windows.Forms.Label();
            this.nameCalon3Label = new System.Windows.Forms.Label();
            this.pointCalon1Label = new System.Windows.Forms.Label();
            this.pointCalon2Label = new System.Windows.Forms.Label();
            this.pointCalon3Label = new System.Windows.Forms.Label();
            this.resultTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.totalVoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // resultChart
            // 
            this.resultChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultChart.BorderlineColor = System.Drawing.Color.Maroon;
            this.resultChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.resultChart.Legends.Add(legend4);
            this.resultChart.Location = new System.Drawing.Point(25, 69);
            this.resultChart.Name = "resultChart";
            this.resultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.resultChart.Series.Add(series4);
            this.resultChart.Size = new System.Drawing.Size(899, 561);
            this.resultChart.TabIndex = 0;
            this.resultChart.Text = "Result";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedTrackBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.speedTrackBar.Location = new System.Drawing.Point(81, 673);
            this.speedTrackBar.Maximum = 1000;
            this.speedTrackBar.Minimum = 1;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(880, 45);
            this.speedTrackBar.TabIndex = 1;
            this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speedTrackBar.Value = 300;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.Color.OrangeRed;
            this.startButton.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(1059, 661);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(279, 66);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1131, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Result";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(611, 38);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Hasil Perolehan Voting Calon Ketua";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fast";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(981, 684);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Slow";
            // 
            // nameCalon2Label
            // 
            this.nameCalon2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCalon2Label.AutoSize = true;
            this.nameCalon2Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCalon2Label.Location = new System.Drawing.Point(935, 181);
            this.nameCalon2Label.Name = "nameCalon2Label";
            this.nameCalon2Label.Size = new System.Drawing.Size(81, 18);
            this.nameCalon2Label.TabIndex = 8;
            this.nameCalon2Label.Text = "Calon 2 : ";
            // 
            // nameCalon1Label
            // 
            this.nameCalon1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCalon1Label.AutoSize = true;
            this.nameCalon1Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCalon1Label.Location = new System.Drawing.Point(935, 89);
            this.nameCalon1Label.Name = "nameCalon1Label";
            this.nameCalon1Label.Size = new System.Drawing.Size(81, 18);
            this.nameCalon1Label.TabIndex = 9;
            this.nameCalon1Label.Text = "Calon 1 : ";
            // 
            // nameCalon3Label
            // 
            this.nameCalon3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCalon3Label.AutoSize = true;
            this.nameCalon3Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCalon3Label.Location = new System.Drawing.Point(935, 282);
            this.nameCalon3Label.Name = "nameCalon3Label";
            this.nameCalon3Label.Size = new System.Drawing.Size(75, 18);
            this.nameCalon3Label.TabIndex = 10;
            this.nameCalon3Label.Text = "Calon 3 :";
            // 
            // pointCalon1Label
            // 
            this.pointCalon1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointCalon1Label.AutoSize = true;
            this.pointCalon1Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCalon1Label.Location = new System.Drawing.Point(952, 115);
            this.pointCalon1Label.Name = "pointCalon1Label";
            this.pointCalon1Label.Size = new System.Drawing.Size(20, 21);
            this.pointCalon1Label.TabIndex = 11;
            this.pointCalon1Label.Text = "0";
            // 
            // pointCalon2Label
            // 
            this.pointCalon2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointCalon2Label.AutoSize = true;
            this.pointCalon2Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCalon2Label.Location = new System.Drawing.Point(952, 210);
            this.pointCalon2Label.Name = "pointCalon2Label";
            this.pointCalon2Label.Size = new System.Drawing.Size(20, 21);
            this.pointCalon2Label.TabIndex = 12;
            this.pointCalon2Label.Text = "0";
            // 
            // pointCalon3Label
            // 
            this.pointCalon3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointCalon3Label.AutoSize = true;
            this.pointCalon3Label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointCalon3Label.Location = new System.Drawing.Point(954, 306);
            this.pointCalon3Label.Name = "pointCalon3Label";
            this.pointCalon3Label.Size = new System.Drawing.Size(20, 21);
            this.pointCalon3Label.TabIndex = 13;
            this.pointCalon3Label.Text = "0";
            // 
            // resultTimer
            // 
            this.resultTimer.Interval = 300;
            this.resultTimer.Tick += new System.EventHandler(this.resultTimer_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(934, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total Jumlah Vote";
            // 
            // totalVoteLabel
            // 
            this.totalVoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalVoteLabel.AutoSize = true;
            this.totalVoteLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVoteLabel.Location = new System.Drawing.Point(948, 412);
            this.totalVoteLabel.Name = "totalVoteLabel";
            this.totalVoteLabel.Size = new System.Drawing.Size(21, 24);
            this.totalVoteLabel.TabIndex = 15;
            this.totalVoteLabel.Text = "0";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.totalVoteLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pointCalon3Label);
            this.Controls.Add(this.pointCalon2Label);
            this.Controls.Add(this.pointCalon1Label);
            this.Controls.Add(this.nameCalon3Label);
            this.Controls.Add(this.nameCalon1Label);
            this.Controls.Add(this.nameCalon2Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.resultChart);
            this.Name = "ResultForm";
            this.Text = "Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameCalon2Label;
        private System.Windows.Forms.Label nameCalon1Label;
        private System.Windows.Forms.Label nameCalon3Label;
        private System.Windows.Forms.Label pointCalon1Label;
        private System.Windows.Forms.Label pointCalon2Label;
        private System.Windows.Forms.Label pointCalon3Label;
        private System.Windows.Forms.Timer resultTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalVoteLabel;
    }
}