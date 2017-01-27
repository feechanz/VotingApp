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
    public partial class CalonForm : Form
    {
        public CalonForm()
        {
            InitializeComponent();
            isiData();
        }

        private void isiData()
        {
            //hima akun
            nrpAk1TextBox.Text = AppHelper.DBVoteCtx.CalonHimaAkun1.NRP;
            namaAk1TextBox.Text = AppHelper.DBVoteCtx.CalonHimaAkun1.Nama;

            nrpAk2TextBox.Text = AppHelper.DBVoteCtx.CalonHimaAkun2.NRP;
            namaAk2TextBox.Text = AppHelper.DBVoteCtx.CalonHimaAkun2.Nama;

            nrpAk3TextBox.Text = AppHelper.DBVoteCtx.CalonHimaAkun3.NRP;
            namaAk3TextBox.Text = AppHelper.DBVoteCtx.CalonHimaAkun3.Nama;

            //hima mene
            nrpMe1TextBox.Text = AppHelper.DBVoteCtx.CalonHimaMene1.NRP;
            namaMe1TextBox.Text = AppHelper.DBVoteCtx.CalonHimaMene1.Nama;

            nrpMe2TextBox.Text = AppHelper.DBVoteCtx.CalonHimaMene2.NRP;
            namaMe2TextBox.Text = AppHelper.DBVoteCtx.CalonHimaMene2.Nama;

            nrpMe3TextBox.Text = AppHelper.DBVoteCtx.CalonHimaMene3.NRP;
            namaMe3TextBox.Text = AppHelper.DBVoteCtx.CalonHimaMene3.Nama;

            //senat ekonomi
            nrpSe1TextBox.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi1.NRP;
            namaSe1TextBox.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi1.Nama;

            nrpSe2TextBox.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi2.NRP;
            namaSe2TextBox.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi2.Nama;

            nrpSe3TextBox.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi3.NRP;
            namaSe3TextBox.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi3.Nama;
        }

        private void Login()
        {
            if (loginButton.Text != "Ganti")
            {
                if (passwordTextBox.Text == AppHelper.DBVoteCtx.PasswordCalon)
                {
                    MessageBox.Show("Login anda berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;

                    this.Height = 500;
                    this.Width = 600;
                    passwordTextBox.Text = "";

                    loginButton.Text = "Ganti";
                }
                else
                {
                    MessageBox.Show("Password anda salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTextBox.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("Apakah anda yakin akan mengganti password?", "Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (passwordTextBox.Text.Trim() != "")
                    {
                        AppHelper.DBVoteCtx.PasswordCalon = passwordTextBox.Text;
                        AppHelper.saveDBVote();
                        passwordTextBox.Text = "";
                        MessageBox.Show("Password berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveAkunButton_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            try
            {
                AppHelper.DBVoteCtx.CalonHimaAkun1.NRP = nrpAk1TextBox.Text;
                AppHelper.DBVoteCtx.CalonHimaAkun1.Nama = namaAk1TextBox.Text;

                AppHelper.DBVoteCtx.CalonHimaAkun2.NRP = nrpAk2TextBox.Text;
                AppHelper.DBVoteCtx.CalonHimaAkun2.Nama = namaAk2TextBox.Text;

                AppHelper.DBVoteCtx.CalonHimaAkun3.NRP = nrpAk3TextBox.Text;
                AppHelper.DBVoteCtx.CalonHimaAkun3.Nama = namaAk3TextBox.Text;
                AppHelper.saveDBVote();
            }
            catch (Exception ex)
            {
                cancel = true;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!cancel)
            {
                MessageBox.Show("Data Hima Akuntansi telah disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveManaButton_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            try
            {
                AppHelper.DBVoteCtx.CalonHimaMene1.NRP = nrpMe1TextBox.Text;
                AppHelper.DBVoteCtx.CalonHimaMene1.Nama = namaMe1TextBox.Text;

                AppHelper.DBVoteCtx.CalonHimaMene2.NRP = nrpMe2TextBox.Text;
                AppHelper.DBVoteCtx.CalonHimaMene2.Nama = namaMe2TextBox.Text;

                AppHelper.DBVoteCtx.CalonHimaMene3.NRP = nrpMe3TextBox.Text;
                AppHelper.DBVoteCtx.CalonHimaMene3.Nama = namaMe3TextBox.Text;
                AppHelper.saveDBVote();
            }
            catch (Exception ex)
            {
                cancel = true;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!cancel)
            {
                MessageBox.Show("Data Hima Manajemen telah disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveSenatButton_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            try
            {
                AppHelper.DBVoteCtx.CalonSenatEkonomi1.NRP = nrpSe1TextBox.Text;
                AppHelper.DBVoteCtx.CalonSenatEkonomi1.Nama = namaSe1TextBox.Text;

                AppHelper.DBVoteCtx.CalonSenatEkonomi2.NRP = nrpSe2TextBox.Text;
                AppHelper.DBVoteCtx.CalonSenatEkonomi2.Nama = namaSe2TextBox.Text;

                AppHelper.DBVoteCtx.CalonSenatEkonomi3.NRP = nrpSe3TextBox.Text;
                AppHelper.DBVoteCtx.CalonSenatEkonomi3.Nama = namaSe3TextBox.Text;
                AppHelper.saveDBVote();
            }
            catch (Exception ex)
            {
                cancel = true;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!cancel)
            {
                MessageBox.Show("Data Senat Ekonomi telah disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
