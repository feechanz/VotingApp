using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Server
{
    public static class AppHelper
    {
        public static string Crypt(string text)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(text));
        }

        public static string Derypt(string text)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(text));
        }
        public static DBVote DBVoteCtx { get; set; }

        public static void loadDBVote()
        {
            try
            {
                DBVoteCtx = DBVote.LoadFromJson(@"DBVote.json");
            }
            catch (Exception e)
            {
                DBVoteCtx = new DBVote();
                //ConnectionObj.Port = "5432";
                //ConnectionObj.IpAddress = "";
            }
        }
        public static void saveDBVote()
        {
            AppHelper.DBVoteCtx.SaveToJson(@"DBVote.json");
        }
    }
}
