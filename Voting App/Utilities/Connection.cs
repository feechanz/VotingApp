using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class Connection
    {
        public string IpAddress { get; set; }
        public string Port { get; set; }

        public void SaveToJson(string filename)
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(filename, json);

        }
        public static Connection LoadFromJson(string filename)
        {
            string json = File.ReadAllText(filename);
            Connection jsonobj = JsonConvert.DeserializeObject<Connection>(json);
            return jsonobj;
        }
    }
}
