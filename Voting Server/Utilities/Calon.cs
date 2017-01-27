using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Server
{
    public class Calon
    {
        public Calon(string nama,string nrp)
        {
            Nama = nama;
            NRP = nrp;
        }
        public string NRP { get; set; }
        public string Nama { get; set; }
    }
}
