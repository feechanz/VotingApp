using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_Server
{
    public class AsyncService
    {
        private IPAddress ipAddress;
        private int port;
        private ListBox listbox;
        public AsyncService(int port, ListBox lb,TextBox ipTb)
        {
            listbox = lb;
            this.port = port;
            string hostName = Dns.GetHostName();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(hostName);
            this.ipAddress = null;
            //ipAddress = IPAddress.Parse("172.0.0.1");
            for (int i = 0; i < ipHostInfo.AddressList.Length; ++i)
            {
                if (ipHostInfo.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                {
                    this.ipAddress = ipHostInfo.AddressList[i];
                    break;
                }
            }
            ipTb.Text = ipAddress.MapToIPv4().ToString();
            listbox.Items.Add("Your Ip address is "+ipAddress);
            if (this.ipAddress == null)
            {
                throw new Exception("No IPv4 address for server");
            }
        }
        public async void Run()
        {
            TcpListener listener = new TcpListener(this.ipAddress, this.port);
            listener.Start();
            listbox.Items.Add("Voting Server service is now running on port " + this.port);
    
            while (true)
            {
                try
                {
                    TcpClient tcpClient = await listener.AcceptTcpClientAsync();
                    Task t = Process(tcpClient);
                    await t;
                }
                catch (Exception ex)
                {
                    listbox.Items.Add(ex.Message);
                }
            }
        }
        private async Task Process(TcpClient tcpClient)
        {
            string clientEndPoint =
    tcpClient.Client.RemoteEndPoint.ToString();
            Console.WriteLine("Received connection request from "
              + clientEndPoint);
            try
            {
                NetworkStream networkStream = tcpClient.GetStream();
                StreamReader reader = new StreamReader(networkStream);
                StreamWriter writer = new StreamWriter(networkStream);
                writer.AutoFlush = true;
                while (true)
                {
                    string request = await reader.ReadLineAsync();
                    if (request != null)
                    {
                        listbox.Items.Add("Received service request: " + request);
                        string response = Response(request);
                        listbox.Items.Add("Server Response is: " + response + "\n");
                        await writer.WriteLineAsync(response);
                    }
                    else
                        break; // Client closed connection
                }
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (tcpClient.Connected)
                {
                    tcpClient.Close();
                }
            }
        }
        private static string Response(string request)
        {
            string[] pairs = request.Split('&');
            string requestName = pairs[0].Split('=')[1];
            string valueString = pairs[1].Split('=')[1];
            //string[] values = valueString.Split(' ');
            //double[] vals = new double[values.Length];
            //for (int i = 0; i < values.Length; ++i)
            //{
            //    vals[i] = double.Parse(values[i]);
            //}
            string response = "";
            if (requestName == "test")
            {
                response = "ok";
            }
            else if (requestName == "login")
            {
                response = Login(valueString);
                //response += Minimum(vals);
            }
            else if(requestName == "vote")
            {
                string valueString2 = pairs[2].Split('=')[1];
                string valueString3 = pairs[3].Split('=')[1];
                Vote pil1 = new Vote(valueString,valueString2);
                Vote pil2 = new Vote(valueString,valueString3);
                AppHelper.DBVoteCtx.Votes.Add(pil1);
                AppHelper.DBVoteCtx.Votes.Add(pil2);
                AppHelper.saveDBVote();
                response = "ok";
            }
            else
            {
                response += "BAD methodName: " + requestName;
            }
            //int delay = ((int)vals[0]) * 1000; // Dummy delay
            //System.Threading.Thread.Sleep(delay);
            return response;
        }

        private static string Login(string nrp)
        {
            string result = "no data";
            foreach(Pengguna p in AppHelper.DBVoteCtx.Penggunas)
            {
                if(p.NRP == nrp)
                {
                    result = p.Nama;
                    break;
                }
            }
            if(result != "no data")
            {
                Vote v = (from item in AppHelper.DBVoteCtx.Votes
                          where item.NRP.Trim() == nrp.Trim()
                          select item).FirstOrDefault();
                if(v != null)
                {
                    result = "already vote";
                }
            }
            return result;
        }
        private static double Average(double[] vals)
        {
            //double sum = 0.0;
            //for (int i = 0; i < vals.Length; ++i)
            //    sum += vals[i];
            return 55;
        }
        private static double Minimum(double[] vals)
        {
            //double min = vals[0]; ;
            //for (int i = 0; i < vals.Length; ++i)
            //    if (vals[i] < min) min = vals[i];
            return 33;
        }
    }
}
