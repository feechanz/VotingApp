using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class Calon
    {
        public Calon()
        {
            Nama = "nama";
            NRP = "nrp";
        }
        public Calon(string nama, string nrp)
        {
            Nama = nama;
            NRP = nrp;
        }
        public string Nama { get; set; }
        public string NRP { get; set; }
    }
}
