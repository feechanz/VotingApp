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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            AppHelper.loadDBVote();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int port;
            port = Convert.ToInt32(portTextBox.Text);
            AsyncService service = new AsyncService(port, logListBox, ipTextBox);
            service.Run();
            startButton.Enabled = false;
        }

        private void dataHasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HasilForm form = new HasilForm();
            form.ShowDialog();
        }

        private void penggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenggunaForm form = new PenggunaForm();
            form.ShowDialog();
        }

        private void totalHasilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalHasilForm form = new TotalHasilForm();
            form.ShowDialog();
        }

        private void calonSenatEkonomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm form = new ResultForm(CalonKetua.Senat_Ekonomi);
            form.ShowDialog();
        }

        private void calonHimaAkuntansiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm form = new ResultForm(CalonKetua.Hima_Akuntansi);
            form.ShowDialog();
        }

        private void calonHimaManajemenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultForm form = new ResultForm(CalonKetua.Hima_Manajemen);
            form.ShowDialog();
        }

        private void calonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalonForm form = new CalonForm();
            form.ShowDialog();
        }

    }

}
