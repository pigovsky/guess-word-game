using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ForRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        const String HttpProtocol = "https://";

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.StartsWith(HttpProtocol)?textBox1.Text:HttpProtocol+textBox1.Text;

            
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resStream = response.GetResponseStream();
                var json = new StreamReader(resStream).ReadToEnd();
                

                var tasks = JsonConvert.DeserializeObject<List<Task>>(json);

                label1.Text = String.Format("{0} {1}", tasks[rnd.Next(tasks.Count)].ToString(), tasks.Count);
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
