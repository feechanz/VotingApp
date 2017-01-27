using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_App
{
    public partial class CalonForm : Form
    {
        public CalonForm()
        {
            InitializeComponent();
            AppHelper.loadCalonDB();
            isiData();
        }

        private void isiData()
        {
            //hima akun
            nrpAk1TextBox.Text = AppHelper.CalonDBObj.CalonHimaAkun1.NRP;
            namaAk1TextBox.Text = AppHelper.CalonDBObj.CalonHimaAkun1.Nama;

            nrpAk2TextBox.Text = AppHelper.CalonDBObj.CalonHimaAkun2.NRP; 
            namaAk2TextBox.Text = AppHelper.CalonDBObj.CalonHimaAkun2.Nama; 

            nrpAk3TextBox.Text = AppHelper.CalonDBObj.CalonHimaAkun3.NRP;
            namaAk3TextBox.Text = AppHelper.CalonDBObj.CalonHimaAkun3.Nama; 

            //hima mene
            nrpMe1TextBox.Text = AppHelper.CalonDBObj.CalonHimaMene1.NRP;
            namaMe1TextBox.Text = AppHelper.CalonDBObj.CalonHimaMene1.Nama;

            nrpMe2TextBox.Text = AppHelper.CalonDBObj.CalonHimaMene2.NRP;
            namaMe2TextBox.Text = AppHelper.CalonDBObj.CalonHimaMene2.Nama;

            nrpMe3TextBox.Text = AppHelper.CalonDBObj.CalonHimaMene3.NRP;
            namaMe3TextBox.Text = AppHelper.CalonDBObj.CalonHimaMene3.Nama;

            //senat ekonomi
            nrpSe1TextBox.Text = AppHelper.CalonDBObj.CalonSenatEkonomi1.NRP;
            namaSe1TextBox.Text = AppHelper.CalonDBObj.CalonSenatEkonomi1.Nama;

            nrpSe2TextBox.Text = AppHelper.CalonDBObj.CalonSenatEkonomi2.NRP;
            namaSe2TextBox.Text = AppHelper.CalonDBObj.CalonSenatEkonomi2.Nama;

            nrpSe3TextBox.Text = AppHelper.CalonDBObj.CalonSenatEkonomi3.NRP;
            namaSe3TextBox.Text = AppHelper.CalonDBObj.CalonSenatEkonomi3.Nama;
        }
        private void Login()
        {
            if (loginButton.Text != "Ganti")
            {
                if (passwordTextBox.Text == AppHelper.CalonDBObj.Password)
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
                if(MessageBox.Show("Apakah anda yakin akan mengganti password?","Password",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(passwordTextBox.Text.Trim() != "")
                    {
                        AppHelper.CalonDBObj.Password = passwordTextBox.Text;
                        AppHelper.saveCalonDB();
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

        private void saveAkunButton_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            try
            {
                AppHelper.CalonDBObj.CalonHimaAkun1.NRP = nrpAk1TextBox.Text;
                AppHelper.CalonDBObj.CalonHimaAkun1.Nama = namaAk1TextBox.Text;

                AppHelper.CalonDBObj.CalonHimaAkun2.NRP = nrpAk2TextBox.Text;
                AppHelper.CalonDBObj.CalonHimaAkun2.Nama = namaAk2TextBox.Text;

                AppHelper.CalonDBObj.CalonHimaAkun3.NRP = nrpAk3TextBox.Text;
                AppHelper.CalonDBObj.CalonHimaAkun3.Nama = namaAk3TextBox.Text;
                AppHelper.saveCalonDB();
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
                AppHelper.CalonDBObj.CalonHimaMene1.NRP = nrpMe1TextBox.Text;
                AppHelper.CalonDBObj.CalonHimaMene1.Nama = namaMe1TextBox.Text;

                AppHelper.CalonDBObj.CalonHimaMene2.NRP = nrpMe2TextBox.Text;
                AppHelper.CalonDBObj.CalonHimaMene2.Nama = namaMe2TextBox.Text;

                AppHelper.CalonDBObj.CalonHimaMene3.NRP = nrpMe3TextBox.Text;
                AppHelper.CalonDBObj.CalonHimaMene3.Nama = namaMe3TextBox.Text;
                AppHelper.saveCalonDB();
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
                AppHelper.CalonDBObj.CalonSenatEkonomi1.NRP = nrpSe1TextBox.Text;
                AppHelper.CalonDBObj.CalonSenatEkonomi1.Nama = namaSe1TextBox.Text;

                AppHelper.CalonDBObj.CalonSenatEkonomi2.NRP = nrpSe2TextBox.Text;
                AppHelper.CalonDBObj.CalonSenatEkonomi2.Nama = namaSe2TextBox.Text;

                AppHelper.CalonDBObj.CalonSenatEkonomi3.NRP = nrpSe3TextBox.Text;
                AppHelper.CalonDBObj.CalonSenatEkonomi3.Nama = namaSe3TextBox.Text;
                AppHelper.saveCalonDB();
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
    }
}
