using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Server
{
    public class Vote
    {
        public Vote(string nrp, string pilihan)
        {
            NRP = nrp;
            Pilihan = pilihan;
            Tanggal = DateTime.Now;
        }
        public string NRP { get; set; }
        public string Pilihan { get; set; }
        public DateTime Tanggal { get; set; }
    }
}
