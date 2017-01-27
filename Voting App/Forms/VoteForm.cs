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
    public partial class VoteForm : Form
    {
        public string Nrp { get; set; }
        public string Nama { get; set; }

        public string pilihan1 { get; set; }
        public string pilihan2 { get; set; }
        public VoteForm(string nrp, string nama)
        {
            InitializeComponent();
            Nrp = nrp;
            Nama = nama;
            welcomeLabel.Text = "Welcome, " + nama + " - " + nrp;
            AppHelper.loadCalonDB();
            VoteSenatUserControl senatctrl = new VoteSenatUserControl(this);
            changeMainPanel(senatctrl);
        }

        public void changeMainPanel(UserControl userControl)
        {

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            //mainPanel.BackColor = userControl.BackColor;
        }

        public async void finishVote(Button finishButton)
        {
            //AppHelper.SendRequest()
            bool success = true;
            try
            {
                string server = AppHelper.ConnectionObj.IpAddress;
                int port = Convert.ToInt32(AppHelper.ConnectionObj.Port);
                string request = "vote";
                string data1 = Nrp;
                string data2 = pilihan1;
                string data3 = pilihan2;
                Task<string> tsResponse = AppHelper.SendRequest(server, port, request, data1,data2,data3);

                await tsResponse;
                if (tsResponse.Result != "ok")
                {
                    success = false;
                    MessageBox.Show(tsResponse.Result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                success = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (success)
            {
                MessageBox.Show("Vote anda telah berhasil!", "Terima kasih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }else
            {
                finishButton.Enabled = true;
            }

        }
    }
}
