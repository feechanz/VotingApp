using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_App
{
    public partial class ExtendForm : Form
    {
        MainForm _mainForm;
        public ExtendForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        public void changeText(string text)
        {
            resultTextBox.Text = text;
            
        }
        public void changeWelcomeText(string text,string nrp)
        {
            if (text == "")
            {
                welcomeLabel.Text = "";
            }
            else
            {
                welcomeLabel.Text = "Welcome, " + text + " - "+ nrp;
                text = DateTime.Now.ToString("dd/MM/yy hh:mm") +" - "+ text + " - "+nrp;
                historyListBox.Items.Insert(0,text);
            }
        }
    }
}
