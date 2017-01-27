using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_Server
{
    public partial class TotalHasilForm : Form
    {
        public TotalHasilForm()
        {
            InitializeComponent();
            AppHelper.loadDBVote();
            refreshDataGrid();
        }
        private void refreshDataGrid()
        {
            resultDataGridView.DataSource = (from item in AppHelper.DBVoteCtx.Votes
                                            where item.NRP.Contains(cariTextBox.Text)
                                            select item).ToList();
        }
        private void Login()
        {
            if (loginButton.Text != "Change")
            {
                if (passwordTextBox.Text.Trim() == AppHelper.DBVoteCtx.PasswordView)
                {
                    this.Height = 540;
                    passwordTextBox.Text = "";
                    loginButton.Text = "Change";
                    cariTextBox.Enabled = true;
                    hapusButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (passwordTextBox.Text.Trim() != "")
                {
                    AppHelper.DBVoteCtx.PasswordView = passwordTextBox.Text;
                    AppHelper.saveDBVote();
                    MessageBox.Show("Password berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    passwordTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void cariTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            refreshDataGrid();
        }

        private void hapusButton_Click(object sender, EventArgs e)
        {
            if(resultDataGridView.SelectedRows.Count > 0)
            {
                Vote vote = resultDataGridView.SelectedRows[0].DataBoundItem as Vote;
                if(MessageBox.Show("Hapus data vote yang terpilih?","Hapus",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Vote item = (from i in AppHelper.DBVoteCtx.Votes
                                 where i.NRP == vote.NRP
                                 && i.Pilihan == vote.Pilihan
                                 select i).FirstOrDefault();
                    AppHelper.DBVoteCtx.Votes.Remove(item);
                    AppHelper.saveDBVote();
                    refreshDataGrid();
                }
            }
        }

    }
}
