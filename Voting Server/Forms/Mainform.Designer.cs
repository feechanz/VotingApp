namespace Voting_Server
{
    partial class Mainform
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
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penggunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hasilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataHasilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalHasilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calonSenatEkonomiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calonHimaAkuntansiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calonHimaManajemenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(12, 98);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 6;
            this.portTextBox.Text = "5432";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(118, 95);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(47, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(12, 138);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(360, 212);
            this.logListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(15, 53);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(150, 20);
            this.ipTextBox.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.calonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penggunaToolStripMenuItem,
            this.calonToolStripMenuItem1,
            this.hasilToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // penggunaToolStripMenuItem
            // 
            this.penggunaToolStripMenuItem.Name = "penggunaToolStripMenuItem";
            this.penggunaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.penggunaToolStripMenuItem.Text = "Pengguna";
            this.penggunaToolStripMenuItem.Click += new System.EventHandler(this.penggunaToolStripMenuItem_Click);
            // 
            // calonToolStripMenuItem1
            // 
            this.calonToolStripMenuItem1.Name = "calonToolStripMenuItem1";
            this.calonToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.calonToolStripMenuItem1.Text = "Calon";
            this.calonToolStripMenuItem1.Click += new System.EventHandler(this.calonToolStripMenuItem1_Click);
            // 
            // hasilToolStripMenuItem
            // 
            this.hasilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataHasilToolStripMenuItem,
            this.totalHasilToolStripMenuItem});
            this.hasilToolStripMenuItem.Name = "hasilToolStripMenuItem";
            this.hasilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hasilToolStripMenuItem.Text = "Hasil";
            // 
            // dataHasilToolStripMenuItem
            // 
            this.dataHasilToolStripMenuItem.Name = "dataHasilToolStripMenuItem";
            this.dataHasilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataHasilToolStripMenuItem.Text = "Total Hasil";
            this.dataHasilToolStripMenuItem.Click += new System.EventHandler(this.dataHasilToolStripMenuItem_Click);
            // 
            // totalHasilToolStripMenuItem
            // 
            this.totalHasilToolStripMenuItem.Name = "totalHasilToolStripMenuItem";
            this.totalHasilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.totalHasilToolStripMenuItem.Text = "Data Hasil";
            this.totalHasilToolStripMenuItem.Click += new System.EventHandler(this.totalHasilToolStripMenuItem_Click);
            // 
            // calonToolStripMenuItem
            // 
            this.calonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calonSenatEkonomiToolStripMenuItem,
            this.calonHimaAkuntansiToolStripMenuItem,
            this.calonHimaManajemenToolStripMenuItem});
            this.calonToolStripMenuItem.Name = "calonToolStripMenuItem";
            this.calonToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.calonToolStripMenuItem.Text = "Hasil Voting";
            // 
            // calonSenatEkonomiToolStripMenuItem
            // 
            this.calonSenatEkonomiToolStripMenuItem.Name = "calonSenatEkonomiToolStripMenuItem";
            this.calonSenatEkonomiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.calonSenatEkonomiToolStripMenuItem.Text = "Senat Ekonomi";
            this.calonSenatEkonomiToolStripMenuItem.Click += new System.EventHandler(this.calonSenatEkonomiToolStripMenuItem_Click);
            // 
            // calonHimaAkuntansiToolStripMenuItem
            // 
            this.calonHimaAkuntansiToolStripMenuItem.Name = "calonHimaAkuntansiToolStripMenuItem";
            this.calonHimaAkuntansiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.calonHimaAkuntansiToolStripMenuItem.Text = "Hima Akuntansi";
            this.calonHimaAkuntansiToolStripMenuItem.Click += new System.EventHandler(this.calonHimaAkuntansiToolStripMenuItem_Click);
            // 
            // calonHimaManajemenToolStripMenuItem
            // 
            this.calonHimaManajemenToolStripMenuItem.Name = "calonHimaManajemenToolStripMenuItem";
            this.calonHimaManajemenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.calonHimaManajemenToolStripMenuItem.Text = "Hima Manajemen";
            this.calonHimaManajemenToolStripMenuItem.Click += new System.EventHandler(this.calonHimaManajemenToolStripMenuItem_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainform";
            this.Text = "Server Vote";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penggunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataHasilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalHasilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calonHimaAkuntansiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calonHimaManajemenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calonSenatEkonomiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calonToolStripMenuItem1;
    }
}

