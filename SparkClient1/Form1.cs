using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkClient1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://api.ciscospark.com/v1/rooms");
            request.Headers.Add("Authorization", "Bearer " + txtAuth.Text);

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseBody = reader.ReadToEnd();

            Console.WriteLine(responseBody);

            reader.Close();
            response.Close();
        }
    }
}
