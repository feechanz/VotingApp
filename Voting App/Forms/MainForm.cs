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
    public partial class MainForm : Form
    {
        ExtendForm extendForm;
        bool run;
        public MainForm()
        {
            InitializeComponent();
            AppHelper.loadConnection();
            extendForm = new ExtendForm(this);
            run = false;
        }

        private void showExtendWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (extendForm.IsDisposed)
            {
                extendForm = new ExtendForm(this);
                extendForm.Show();
            }
            else
            {
                extendForm.Show();
                extendForm.Focus();
            }
        }

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e)
        {
            extendForm.changeText(nrpTextBox.Text);
        }

        private async void openVoteForm()
        {
            if (!run)
            {
                submitButton.Enabled = false;
                run = true;
                bool success = true;
                string name = "";
                try
                {
                    string server = AppHelper.ConnectionObj.IpAddress;
                    int port = Convert.ToInt32(AppHelper.ConnectionObj.Port);
                    string request = "login";
                    string data = nrpTextBox.Text;
                    Task<string> tsResponse = AppHelper.SendRequest(server, port, request, data);

                    await tsResponse;
                    if (tsResponse.Result.Trim() == "no data")
                    {
                        success = false;
                        MessageBox.Show("Tidak ada data untuk NRP " + nrpTextBox.Text + " pada server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nrpTextBox.Focus();
                    }
                    else if(tsResponse.Result.Trim() == "already vote")
                    {
                        success = false;
                        MessageBox.Show(nrpTextBox.Text + " sudah pernah voting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        nrpTextBox.Focus();
                    }
                    else if(tsResponse.Result.ToLower().Contains("connection") || tsResponse.Result.ToLower().Contains("requested"))
                    {
                        success = false;
                        MessageBox.Show(tsResponse.Result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        name = tsResponse.Result.Trim();
                    }
                }
                catch (Exception ex)
                {
                    success = false;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (success)
                {
                    string nrp = nrpTextBox.Text;
                    MessageBox.Show("Welcome, " + name);
                    extendForm.changeWelcomeText(name,nrp);
                    VoteForm form = new VoteForm(nrp,name);
                    form.ShowDialog();
                    extendForm.changeWelcomeText("","");
                    nrpTextBox.Text = "";
                
                }
                
                run = false;
                submitButton.Enabled = true;
            }
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
           openVoteForm();
        }

        private void nrpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                openVoteForm();
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm form = new ConnectionForm();
            form.ShowDialog();
        }

        private void calonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalonForm form = new CalonForm();
            form.ShowDialog();
        }


    }
}
