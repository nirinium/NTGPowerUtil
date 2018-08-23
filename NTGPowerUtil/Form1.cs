using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Serialization;
using System.IO;

namespace NTGPowerUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                myProcess.StartInfo.UseShellExecute = true;
                //myProcess.StartInfo.FileName = comboBox1.SelectedItem.ToString();
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private void btnAddServer_Click(object sender, EventArgs e)
        {
            FileInfo svr = new FileInfo(@"Servers.txt");
            using (StreamWriter sw = svr.AppendText())
            {
                sw.WriteLine(textBox1.Text);
            }
        }

        private void SettingsFile()
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@"Servers.txt");
            string[] servers = File.ReadAllLines(@"Servers.txt");
            listBox1.Items.AddRange(servers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
