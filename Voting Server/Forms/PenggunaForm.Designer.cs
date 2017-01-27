namespace Voting_Server
{
    partial class PenggunaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nrpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.importTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.penggunaDataGridView = new System.Windows.Forms.DataGridView();
            this.NrpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importButton = new System.Windows.Forms.Button();
            this.hapusButton = new System.Windows.Forms.Button();
            this.cariTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.namaTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nrpTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Pengguna";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(282, 71);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Tambah";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // namaTextBox
            // 
            this.namaTextBox.Location = new System.Drawing.Point(70, 45);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(287, 20);
            this.namaTextBox.TabIndex = 2;
            this.namaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namaTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // nrpTextBox
            // 
            this.nrpTextBox.Location = new System.Drawing.Point(70, 19);
            this.nrpTextBox.MaxLength = 7;
            this.nrpTextBox.Name = "nrpTextBox";
            this.nrpTextBox.Size = new System.Drawing.Size(109, 20);
            this.nrpTextBox.TabIndex = 1;
            this.nrpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nrpTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NRP";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(294, 130);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseFileButton.TabIndex = 4;
            this.chooseFileButton.Text = "Choose File";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // importTextBox
            // 
            this.importTextBox.Location = new System.Drawing.Point(12, 133);
            this.importTextBox.Name = "importTextBox";
            this.importTextBox.ReadOnly = true;
            this.importTextBox.Size = new System.Drawing.Size(276, 20);
            this.importTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Import dari CSV";
            // 
            // penggunaDataGridView
            // 
            this.penggunaDataGridView.AllowUserToAddRows = false;
            this.penggunaDataGridView.AllowUserToDeleteRows = false;
            this.penggunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.penggunaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrpColumn,
            this.NamaColumn});
            this.penggunaDataGridView.Location = new System.Drawing.Point(6, 233);
            this.penggunaDataGridView.MultiSelect = false;
            this.penggunaDataGridView.Name = "penggunaDataGridView";
            this.penggunaDataGridView.ReadOnly = true;
            this.penggunaDataGridView.RowHeadersVisible = false;
            this.penggunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.penggunaDataGridView.Size = new System.Drawing.Size(363, 228);
            this.penggunaDataGridView.TabIndex = 4;
            // 
            // NrpColumn
            // 
            this.NrpColumn.DataPropertyName = "NRP";
            this.NrpColumn.HeaderText = "NRP";
            this.NrpColumn.Name = "NrpColumn";
            this.NrpColumn.ReadOnly = true;
            // 
            // NamaColumn
            // 
            this.NamaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaColumn.DataPropertyName = "Nama";
            this.NamaColumn.HeaderText = "Nama";
            this.NamaColumn.Name = "NamaColumn";
            this.NamaColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pengguna";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV Files|*.csv|All files|*.*";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(294, 159);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // hapusButton
            // 
            this.hapusButton.Location = new System.Drawing.Point(294, 204);
            this.hapusButton.Name = "hapusButton";
            this.hapusButton.Size = new System.Drawing.Size(75, 23);
            this.hapusButton.TabIndex = 7;
            this.hapusButton.Text = "Hapus";
            this.hapusButton.UseVisualStyleBackColor = true;
            this.hapusButton.Click += new System.EventHandler(this.hapusButton_Click);
            // 
            // cariTextBox
            // 
            this.cariTextBox.Location = new System.Drawing.Point(82, 207);
            this.cariTextBox.Name = "cariTextBox";
            this.cariTextBox.Size = new System.Drawing.Size(186, 20);
            this.cariTextBox.TabIndex = 8;
            this.cariTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cariTextBox_KeyDown);
            // 
            // PenggunaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 462);
            this.Controls.Add(this.cariTextBox);
            this.Controls.Add(this.hapusButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.penggunaDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.importTextBox);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PenggunaForm";
            this.Text = "Pengguna";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nrpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox importTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView penggunaDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaColumn;
        private System.Windows.Forms.Button hapusButton;
        private System.Windows.Forms.TextBox cariTextBox;

    }
}