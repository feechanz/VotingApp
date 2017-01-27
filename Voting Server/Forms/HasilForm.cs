using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Voting_Server
{
    public partial class HasilForm : Form
    {

        
        public HasilForm()
        {
            InitializeComponent();
            initializeForm();
           
        }

        private void initializeForm()
        {
            //senat
            senat1NRPlabel.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi1.NRP;
            senat1NamaLabel.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi1.Nama;

            senat2NRPlabel.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi2.NRP;
            senat2NamaLabel.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi2.Nama;

            senat3NRPlabel.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi3.NRP;
            senat3NamaLabel.Text = AppHelper.DBVoteCtx.CalonSenatEkonomi3.Nama;

            //hima akun
            himak1NRPLabel.Text = AppHelper.DBVoteCtx.CalonHimaAkun1.NRP;
            himak1NamaLabel.Text = AppHelper.DBVoteCtx.CalonHimaAkun1.Nama;

            himak2NRPLabel.Text = AppHelper.DBVoteCtx.CalonHimaAkun2.NRP;
            himak2NamaLabel.Text = AppHelper.DBVoteCtx.CalonHimaAkun2.Nama;

            himak3NRPLabel.Text = AppHelper.DBVoteCtx.CalonHimaAkun3.NRP;
            himak3NamaLabel.Text = AppHelper.DBVoteCtx.CalonHimaAkun3.Nama;

            //hima mene
            himama1NRPLabel.Text = AppHelper.DBVoteCtx.CalonHimaMene1.NRP;
            himama1NamaLabel.Text = AppHelper.DBVoteCtx.CalonHimaMene1.Nama;

            himama2NRPLabel.Text = AppHelper.DBVoteCtx.CalonHimaMene2.NRP;
            himama2NamaLabel.Text = AppHelper.DBVoteCtx.CalonHimaMene2.Nama;

            himama3NRPLabel.Text = AppHelper.DBVoteCtx.CalonHimaMene3.NRP;
            himama3NamaLabel.Text = AppHelper.DBVoteCtx.CalonHimaMene3.Nama;

            //score 
            //senat
            CountCalon(AppHelper.DBVoteCtx.CalonSenatEkonomi1, AppHelper.DBVoteCtx.CalonSenatEkonomi2, AppHelper.DBVoteCtx.CalonSenatEkonomi3, calonSenat1ProgressBar, calonSenat2ProgressBar, calonSenat3ProgressBar,senat1ScoreLabel,senat2ScoreLabel,senat3ScoreLabel);
            //hima akun
            CountCalon(AppHelper.DBVoteCtx.CalonHimaAkun1, AppHelper.DBVoteCtx.CalonHimaAkun2, AppHelper.DBVoteCtx.CalonHimaAkun3, calonHimak1ProgressBar, calonHimak2ProgressBar, calonHimak3ProgressBar,himak1ScoreLabel,himak2ScoreLabel,himak3ScoreLabel);
            //hima mene
            CountCalon(AppHelper.DBVoteCtx.CalonHimaMene1, AppHelper.DBVoteCtx.CalonHimaMene2, AppHelper.DBVoteCtx.CalonHimaMene3, calonHimama1ProgressBar, calonHimama2ProgressBar, calonHimama3ProgressBar,himama1ScoreLabel,himama2ScoreLabel,himama3ScoreLabel);
            
        }

        private void CountCalon(Calon Calon1, Calon Calon2, Calon Calon3, ProgressBar pgCalon1, ProgressBar pgCalon2, ProgressBar pgCalon3,Label scoreLabel1, Label scoreLabel2, Label scoreLabel3)
        {
           
            List<Vote> Votes = (from item in AppHelper.DBVoteCtx.Votes
                                where item.Pilihan == Calon1.NRP ||
                                item.Pilihan == Calon2.NRP ||
                                item.Pilihan == Calon3.NRP
                                select item).ToList();

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
            while (Maximum < CountVoteMax)
            {
                Maximum += 50;
            }

            pgCalon1.Maximum = Maximum;
            pgCalon2.Maximum = Maximum;
            pgCalon3.Maximum = Maximum;

            pgCalon1.Value = CountVoteCalon1;
            pgCalon2.Value = CountVoteCalon2;
            pgCalon3.Value = CountVoteCalon3;

            scoreLabel1.Text = CountVoteCalon1.ToString();
            scoreLabel2.Text = CountVoteCalon2.ToString();
            scoreLabel3.Text = CountVoteCalon3.ToString();
        }

      
    }
}
