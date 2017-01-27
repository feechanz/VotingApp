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
    public enum CalonKetua
    {
        Senat_Ekonomi,Hima_Akuntansi,Hima_Manajemen
    }
    public partial class ResultForm : Form
    {
        public int PointCalon1 { get; set; }
        public int PointCalon2 { get; set; }
        public int PointCalon3 { get; set; }

        public Calon Calon1 { get; set; }
        public Calon Calon2 { get; set; }
        public Calon Calon3 { get; set; }

        public List<Vote> Votes { get; set; }
        public bool Play { get; set; }
        public int IndeksCount { get; set; }
        public int TotalVote { get; set; }

        public ResultForm(CalonKetua calonKetua)
        {
            InitializeComponent();
            initializeDefault(calonKetua);
            resultTimer.Interval = speedTrackBar.Value;

        }

        private void initializeChart(CalonKetua calonKetua)
        {
            Play = true;

            IndeksCount = 0;
            TotalVote = 0;
            PointCalon1 = 0;
            PointCalon2 = 0;
            PointCalon3 = 0;

            resultChart.Series.Clear();
            resultChart.Series.Add("Vote");

            int CountVoteCalon1 = (from item in Votes
                                   where item.Pilihan == Calon1.NRP
                                   select item).Count();
            int CountVoteCalon2 = (from item in Votes
                                   where item.Pilihan == Calon2.NRP
                                   select item).Count();
            int CountVoteCalon3 = (from item in Votes
                                   where item.Pilihan == Calon3.NRP
                                   select item).Count();
            int CountVoteMax = Math.Max(Math.Max(CountVoteCalon1, CountVoteCalon2), CountVoteCalon3);

            int Maximum = 50;
            while(Maximum < CountVoteMax)
            {
                Maximum += 50;
            }

            resultChart.ChartAreas[0].AxisY.Maximum = Maximum;

            nameCalon1Label.Text = Calon1.NRP + " - " + Calon1.Nama;
            nameCalon2Label.Text = Calon2.NRP + " - " + Calon2.Nama;
            nameCalon3Label.Text = Calon3.NRP + " - " + Calon3.Nama;
            
            resultChart.Series["Vote"].Points.AddXY(Calon1.NRP + " - " + Calon1.Nama, PointCalon1);
            resultChart.Series["Vote"].Points.AddXY(Calon2.NRP + " - " + Calon2.Nama, PointCalon2);
            resultChart.Series["Vote"].Points.AddXY(Calon3.NRP + " - " + Calon3.Nama, PointCalon3);
        }
        private void initializeDefault(CalonKetua calonKetua)
        {
            if (calonKetua == CalonKetua.Senat_Ekonomi)
            {
                titleLabel.Text += " Senat Ekonomi";
                Calon1 = AppHelper.DBVoteCtx.CalonSenatEkonomi1;
                Calon2 = AppHelper.DBVoteCtx.CalonSenatEkonomi2;
                Calon3 = AppHelper.DBVoteCtx.CalonSenatEkonomi3;
            }
            else if (calonKetua == CalonKetua.Hima_Akuntansi)
            {
                titleLabel.Text += " Hima Akuntansi";
                Calon1 = AppHelper.DBVoteCtx.CalonHimaAkun1;
                Calon2 = AppHelper.DBVoteCtx.CalonHimaAkun2;
                Calon3 = AppHelper.DBVoteCtx.CalonHimaAkun3;
            }
            else if (calonKetua == CalonKetua.Hima_Manajemen)
            {
                titleLabel.Text += " Hima Manajemen";
                Calon1 = AppHelper.DBVoteCtx.CalonHimaMene1;
                Calon2 = AppHelper.DBVoteCtx.CalonHimaMene2;
                Calon3 = AppHelper.DBVoteCtx.CalonHimaMene3;
            }

            //real data
            Votes = (from item in AppHelper.DBVoteCtx.Votes
                     where item.Pilihan == Calon1.NRP ||
                     item.Pilihan == Calon2.NRP ||
                     item.Pilihan == Calon3.NRP
                     select item).ToList();

            ////dummy data
            //Votes = DummyDataVote(1000, 33,33,33);

            initializeChart(calonKetua);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool doit = false ;
            if (startButton.Text == "Start")
            {
                if (MessageBox.Show("Apakah anda yakin untuk memulai menampilkan hasil data?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    doit = true;
                }
            }
            else if(startButton.Text == "Close")
            {
                doit = false;
                if(MessageBox.Show("Menutup hasil Vote?","Pertanyaan",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                doit = true;
            }

            if (doit)
            {
                if (Play)
                {
                    startButton.Text = "Pause";
                    resultTimer.Start();
                }
                else
                {
                    startButton.Text = "Resume";
                    resultTimer.Stop();
                }
                Play = !Play;
            }
        }

        
        private void UpdateChart()
        {
            if (IndeksCount == Votes.Count())
            {
                //stop
                Play = !Play;
                resultTimer.Stop();
                MessageBox.Show("Hasil Voting telah semua selesai", "Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                startButton.Text = "Close";
            }
            else
            {
                if(Votes[IndeksCount].Pilihan == Calon1.NRP)
                {
                    PointCalon1++;
                }
                else if (Votes[IndeksCount].Pilihan == Calon2.NRP)
                {
                    PointCalon2++;
                }
                else if (Votes[IndeksCount].Pilihan == Calon3.NRP)
                {
                    PointCalon3++;
                }
                IndeksCount++;

                TotalVote++;

                resultChart.Series.Clear();
                resultChart.Series.Add("Vote");
                resultChart.Series["Vote"].Points.AddXY(Calon1.NRP + " - " + Calon1.Nama, PointCalon1);
                resultChart.Series["Vote"].Points.AddXY(Calon2.NRP + " - " + Calon2.Nama, PointCalon2);
                resultChart.Series["Vote"].Points.AddXY(Calon3.NRP + " - " + Calon3.Nama, PointCalon3);
                pointCalon1Label.Text = PointCalon1.ToString();
                pointCalon2Label.Text = PointCalon2.ToString();
                pointCalon3Label.Text = PointCalon3.ToString();
                totalVoteLabel.Text = TotalVote.ToString();
            }
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            resultTimer.Interval = speedTrackBar.Value;
        }

        private void resultTimer_Tick(object sender, EventArgs e)
        {
            UpdateChart();
        }
        private List<Vote> DummyDataVote(int count, int prob1, int prob2, int prob3)
        {
            Random r = new Random();
            List<Vote> Result = new List<Vote>();
            
            for(int i=0;i<count;i++)
            {
                int a = r.Next(100);
                Vote item;
                if (a < prob1)
                {
                    item = new Vote("1", Calon1.NRP);
                }
                else if(a < prob1+prob2)
                {
                    item = new Vote("2", Calon2.NRP);
                }
                else
                {
                    item = new Vote("3", Calon3.NRP);
                }
                Result.Add(item);
            }
            return Result;
        }

        
    }
}
