﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Server
{
    public class DBVote
    {
        public DateTime LastUpdate { get; set; }
        public string PasswordCalon { get; set; }
        public string PasswordView { get; set; }
        public BindingList<Pengguna> Penggunas { get; set; }
        public BindingList<Vote> Votes { get; set; }

        public DBVote()
        {
            LastUpdate = DateTime.Now;

            Penggunas = new BindingList<Pengguna>();
            Votes = new BindingList<Vote>();
            PasswordView = "admin";
            PasswordCalon = "calon";


            CalonHimaAkun1 = new Calon("akun1", "nrpaku1");
            CalonHimaAkun2 = new Calon("akun2", "nrpaku2");
            CalonHimaAkun3 = new Calon("akun3", "nrpaku3");

            CalonHimaMene1 = new Calon("mene1", "nrpmen1");
            CalonHimaMene2 = new Calon("mene2", "nrpmen2");
            CalonHimaMene3 = new Calon("mene3", "nrpmen3");

            CalonSenatEkonomi1 = new Calon("senat1", "nrpsen1");
            CalonSenatEkonomi2 = new Calon("senat2", "nrpsen2");
            CalonSenatEkonomi3 = new Calon("senat3", "nrpsen3");
        }

        //calon hima akuntansi
        public Calon CalonHimaAkun1 { get; set; }
        public Calon CalonHimaAkun2 { get; set; }
        public Calon CalonHimaAkun3 { get; set; }

        //calon hima manajemen
        public Calon CalonHimaMene1 { get; set; }
        public Calon CalonHimaMene2 { get; set; }
        public Calon CalonHimaMene3 { get; set; }

        //calon senat ekonomi
        public Calon CalonSenatEkonomi1 { get; set; }
        public Calon CalonSenatEkonomi2 { get; set; }
        public Calon CalonSenatEkonomi3 { get; set; }

        public void SaveToJson(string filename)
        {
            LastUpdate = DateTime.Now;
            string json = JsonConvert.SerializeObject(this);
            json = AppHelper.Crypt(json);
            File.WriteAllText(filename, json);

        }
        public static DBVote LoadFromJson(string filename)
        {
            string json = File.ReadAllText(filename);
            json = AppHelper.Derypt(json);
            DBVote jsonobj = JsonConvert.DeserializeObject<DBVote>(json);
            return jsonobj;
        }
    }
}
