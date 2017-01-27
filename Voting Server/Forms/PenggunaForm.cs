using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_Server
{
    public partial class PenggunaForm : Form
    {
        public PenggunaForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            penggunaDataGridView.DataSource = (from item in AppHelper.DBVoteCtx.Penggunas
                                               where item.NRP.Contains(cariTextBox.Text)
                                               || item.Nama.ToLower().Contains(cariTextBox.Text.ToLower())
                                               select item).ToList();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                importTextBox.Text = openFileDialog.FileName;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if(importTextBox.Text == "")
            {
                MessageBox.Show("Tolong pilih file CSV","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // your code here 
                    string CSVFilePathName = openFileDialog.FileName;
                    string[] Lines = File.ReadAllLines(CSVFilePathName);
                    string[] Fields;
                    Fields = Lines[0].Split(new char[] { ',' });
                    int Cols = Fields.GetLength(0);
                    //DataTable dt = new DataTable();
                    //1st row must be column names; force lower case to ensure matching later on.
                    //for (int i = 0; i < Cols; i++)
                    //    dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                    //DataRow Row;
                    if (Cols > 2)
                    {
                        MessageBox.Show("Mungkin kesalahan format CSV", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                   
                        for (int i = 1; i < Lines.GetLength(0); i++)
                        {
                            Fields = Lines[i].Split(new char[] { ',' });
                            Pengguna p = new Pengguna();
                            p.NRP = Fields[0];
                            p.Nama = Fields[1];
                            AppHelper.DBVoteCtx.Penggunas.Add(p);

                            //Row = dt.NewRow();
                            //for (int f = 0; f < Cols; f++)
                            //{
                            //    Row[f] = Fields[f];
                            //}
                            //dt.Rows.Add(Row);
                        }
                        
                        AppHelper.saveDBVote();
                        refreshDataGrid();
                    }
                    //penggunaDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                }
            }
        }
        private void tambahPengguna()
        {
            if (MessageBox.Show("Apakah yakin menambah data pengguna?", "Tambah", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool cancel = false;
                string message = "";
                foreach (Pengguna item in AppHelper.DBVoteCtx.Penggunas)
                {
                    if (item.NRP == nrpTextBox.Text)
                    {
                        message = "NRP sudah ada pada sistem";
                        cancel = true;
                        break;
                    }
                }
                if (nrpTextBox.Text.Trim() == "")
                {
                    message = "Nrp tidak boleh kosong";
                    cancel = true;
                }
                if (namaTextBox.Text.Trim() == "")
                {
                    message = "Nama tidak boleh kosong";
                    cancel = true;
                }

                if (cancel)
                {
                    MessageBox.Show(message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Pengguna p = new Pengguna();
                    p.NRP = nrpTextBox.Text;
                    p.Nama = namaTextBox.Text;
                    AppHelper.DBVoteCtx.Penggunas.Add(p);
                    AppHelper.saveDBVote();
                    nrpTextBox.Text = "";
                    namaTextBox.Text = "";
                    refreshDataGrid();
                }
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            tambahPengguna();  
        }
        private void nrpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tambahPengguna();
            }
        }
        private void namaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tambahPengguna();
            }
            
        }

        private void hapusButton_Click(object sender, EventArgs e)
        {
            if(penggunaDataGridView.SelectedRows.Count > 0)
            {
                Pengguna pengguna = penggunaDataGridView.SelectedRows[0].DataBoundItem as Pengguna;
                if(MessageBox.Show("Menghapus data pengguna terpilih?","Hapus",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    Pengguna item = (from i in AppHelper.DBVoteCtx.Penggunas
                                     where i.NRP == pengguna.NRP && i.Nama == pengguna.Nama
                                     select i).FirstOrDefault();
                    AppHelper.DBVoteCtx.Penggunas.Remove(item);
                    AppHelper.saveDBVote();
                    refreshDataGrid();
                }
            }
        }

        private void cariTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            refreshDataGrid();
        }

        

    }
}
