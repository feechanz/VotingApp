using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_App
{
    public partial class VoteHimaAkunUserControl : UserControl
    {
        public VoteForm Mainform { get; set; }
        public VoteHimaAkunUserControl(VoteForm mainform)
        {
            InitializeComponent();

            nrpCalon1Label.Text = AppHelper.CalonDBObj.CalonHimaAkun1.NRP;
            namaCalon1Label.Text = AppHelper.CalonDBObj.CalonHimaAkun1.Nama;

            nrpCalon2Label.Text = AppHelper.CalonDBObj.CalonHimaAkun2.NRP;
            namaCalon2Label.Text = AppHelper.CalonDBObj.CalonHimaAkun2.Nama;

            nrpCalon3Label.Text = AppHelper.CalonDBObj.CalonHimaAkun3.NRP;
            namaCalon3Label.Text = AppHelper.CalonDBObj.CalonHimaAkun3.Nama;

            calon1RadioButton.Text = AppHelper.CalonDBObj.CalonHimaAkun1.Nama;
            calon2RadioButton.Text = AppHelper.CalonDBObj.CalonHimaAkun2.Nama;
            calon3RadioButton.Text = AppHelper.CalonDBObj.CalonHimaAkun3.Nama;

            Mainform = mainform;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (calon1RadioButton.Checked || calon2RadioButton.Checked || calon3RadioButton.Checked)
            {
                if (MessageBox.Show("Apakah anda yakin dengan pilihan anda?", "Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string pil;
                    if (calon1RadioButton.Checked)
                    {
                        pil = nrpCalon1Label.Text;
                    }
                    else if (calon2RadioButton.Checked)
                    {
                        pil = nrpCalon2Label.Text;
                    }
                    else
                    {
                        pil = nrpCalon3Label.Text;
                    }
                    Mainform.pilihan2 = pil;
                    nextButton.Enabled = false;
                    Mainform.finishVote(nextButton);
                }
            }
            else
            {
                MessageBox.Show("Tolong pilih salah satu calon!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void calon1PictureBox_Click(object sender, EventArgs e)
        {
            calon1RadioButton.Checked = true;
        }

        private void calon2PictureBox_Click(object sender, EventArgs e)
        {
            calon2RadioButton.Checked = true;
        }

        private void calon3PictureBox_Click(object sender, EventArgs e)
        {
            calon3RadioButton.Checked = true;
        }


    }
}
