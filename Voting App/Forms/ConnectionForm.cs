using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_App
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            
            ipTextBox.Text = AppHelper.ConnectionObj.IpAddress;
            portTextBox.Text = AppHelper.ConnectionObj.Port;
        }


        private async void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string server = ipTextBox.Text;
                int port = Convert.ToInt32(portTextBox.Text);
                string request = "test";
                string data = "22";
                Task<string> tsResponse = AppHelper.SendRequest(server, port, request, data);
                logListBox.Items.Add("Sent request, waiting for response");
                await tsResponse;
                logListBox.Items.Add("Received response: " + tsResponse.Result);
                
            }
            catch (Exception ex)
            {
                logListBox.Items.Add(ex.Message);
            }
            AppHelper.ConnectionObj.IpAddress = ipTextBox.Text;
            AppHelper.ConnectionObj.Port = portTextBox.Text;
            AppHelper.ConnectionObj.SaveToJson(@"Connection.json");

        }

        
    }
}
