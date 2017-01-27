using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Voting_App
{
    public class AppHelper
    {
        public static Connection ConnectionObj { get; set; }
        public static CalonDB CalonDBObj { get; set; }
        public static void loadConnection()
        {
            try
            {
                ConnectionObj = Connection.LoadFromJson(@"Connection.json");
            }
            catch (Exception e)
            {
                ConnectionObj = new Connection();
                ConnectionObj.Port = "5432";
                ConnectionObj.IpAddress = "";
            }
        }
        public static void loadCalonDB()
        {
            try
            {
                CalonDBObj = CalonDB.LoadFromJson(@"calondb.json");
            }
            catch(Exception e)
            {
                CalonDBObj = new CalonDB();
                
            }
        }

        public static void saveCalonDB()
        {
            CalonDBObj.SaveToJson(@"calondb.json");
        }
        public static async Task<string> SendRequest(string server,
  int port, string request, string data)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(server);
                IPHostEntry ipHostInfo = Dns.GetHostEntry(server);
                //for (int i = 0; i < ipHostInfo.AddressList.Length; ++i)
                //{
                //    if (ipHostInfo.AddressList[i].AddressFamily ==
                //      AddressFamily.InterNetwork)
                //    {
                //        ipAddress = ipHostInfo.AddressList[i];
                //        break;
                //    }
                //}
                //if (ipAddress == null)
                //    throw new Exception("No IPv4 address for server");
                TcpClient client = new TcpClient();
                await client.ConnectAsync(ipAddress, port); // Connect
                NetworkStream networkStream = client.GetStream();
                StreamWriter writer = new StreamWriter(networkStream);
                StreamReader reader = new StreamReader(networkStream);
                writer.AutoFlush = true;
                string requestData = "request=" + request + "&" + "data=" +
                  data + "&eor"; // 'End-of-request'
                await writer.WriteLineAsync(requestData);
                string response = await reader.ReadLineAsync();
                client.Close();
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> SendRequest(string server,
  int port, string request, string data1, string data2, string data3)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(server);
                IPHostEntry ipHostInfo = Dns.GetHostEntry(server);
                //for (int i = 0; i < ipHostInfo.AddressList.Length; ++i)
                //{
                //    if (ipHostInfo.AddressList[i].AddressFamily ==
                //      AddressFamily.InterNetwork)
                //    {
                //        ipAddress = ipHostInfo.AddressList[i];
                //        break;
                //    }
                //}
                //if (ipAddress == null)
                //    throw new Exception("No IPv4 address for server");
                TcpClient client = new TcpClient();
                await client.ConnectAsync(ipAddress, port); // Connect
                NetworkStream networkStream = client.GetStream();
                StreamWriter writer = new StreamWriter(networkStream);
                StreamReader reader = new StreamReader(networkStream);
                writer.AutoFlush = true;
                string requestData = "request=" + request + "&" + "data1=" +
                  data1 + "&" + "data2=" +
                  data2 + "&" + "data3=" +
                  data3 + "&eor"; // 'End-of-request'
                await writer.WriteLineAsync(requestData);
                string response = await reader.ReadLineAsync();
                client.Close();
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
