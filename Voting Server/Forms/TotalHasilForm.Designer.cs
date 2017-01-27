namespace Voting_Server
{
    partial class TotalHasilForm
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
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.NrpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PilihanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cariTextBox = new System.Windows.Forms.TextBox();
            this.hapusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrpColumn,
            this.PilihanColumn,
            this.TanggalColumn});
            this.resultDataGridView.Location = new System.Drawing.Point(12, 97);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGridView.Size = new System.Drawing.Size(353, 393);
            this.resultDataGridView.TabIndex = 0;
            // 
            // NrpColumn
            // 
            this.NrpColumn.DataPropertyName = "NRP";
            this.NrpColumn.HeaderText = "NRP";
            this.NrpColumn.Name = "NrpColumn";
            this.NrpColumn.ReadOnly = true;
            // 
            // PilihanColumn
            // 
            this.PilihanColumn.DataPropertyName = "Pilihan";
            this.PilihanColumn.HeaderText = "Pilihan";
            this.PilihanColumn.Name = "PilihanColumn";
            this.PilihanColumn.ReadOnly = true;
            // 
            // TanggalColumn
            // 
            this.TanggalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TanggalColumn.DataPropertyName = "Tanggal";
            this.TanggalColumn.HeaderText = "Tanggal";
            this.TanggalColumn.Name = "TanggalColumn";
            this.TanggalColumn.ReadOnly = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(71, 12);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(213, 20);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(290, 10);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cari";
            // 
            // cariTextBox
            // 
            this.cariTextBox.Enabled = false;
            this.cariTextBox.Location = new System.Drawing.Point(55, 67);
            this.cariTextBox.Name = "cariTextBox";
            this.cariTextBox.Size = new System.Drawing.Size(162, 20);
            this.cariTextBox.TabIndex = 4;
            this.cariTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cariTextBox_KeyDown);
            // 
            // hapusButton
            // 
            this.hapusButton.Enabled = false;
            this.hapusButton.Location = new System.Drawing.Point(290, 68);
            this.hapusButton.Name = "hapusButton";
            this.hapusButton.Size = new System.Drawing.Size(75, 23);
            this.hapusButton.TabIndex = 6;
            this.hapusButton.Text = "Hapus";
            this.hapusButton.UseVisualStyleBackColor = true;
            this.hapusButton.Click += new System.EventHandler(this.hapusButton_Click);
            // 
            // TotalHasilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 62);
            this.Controls.Add(this.hapusButton);
            this.Controls.Add(this.cariTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.resultDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TotalHasilForm";
            this.Text = "Total Hasil";
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PilihanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cariTextBox;
        private System.Windows.Forms.Button hapusButton;
    }
}