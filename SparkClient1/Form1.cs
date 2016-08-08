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
using Newtonsoft.Json;

namespace SparkClient1
{
    public partial class Form1 : Form
    {
        SparkRoomCollection rooms;
        SparkMessageCollection messages;
        int active_room;

        public Form1()
        {
            InitializeComponent();
        }

        private string GET(string url)
        {
            // Build the request
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("Authorization", "Bearer " + txtAuth.Text);

            // Get response from Spark
            WebResponse response = request.GetResponse();

            // Read the response
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string body = reader.ReadToEnd();

            // Clean up
            reader.Close();
            response.Close();

            return body;
        }

        private void UpdateRooms()
        {
            // Get list of rooms
            string json = GET("https://api.ciscospark.com/v1/rooms");

            /* json will look like:
             * {
             *   "items": [
             *     {
             *       "id": "Y2lzY29zcGFyazovL...",
             *       "title": "Control System Programmers",
             *       "type": "group",
             *       "isLocked": false,
             *       "lastActivity": "2016-07-12T21:24:20.684Z",
             *       "created": "2016-05-17T15:28:53.019Z"
             *     },
             *     ...
             *   ]
             * }
             */
            rooms = JsonConvert.DeserializeObject<SparkRoomCollection>(json);

            lstRooms.Items.Clear();

            foreach (SparkRoom r in rooms.items)
            {
                lstRooms.Items.Add(r.title);
            }

            active_room = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            UpdateRooms();
        }

        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            active_room = lstRooms.SelectedIndex;

            lblMessages.Visible = true;
            lstMessages.Visible = true;

            // Get list of messages in this room
            string json = GET("https://api.ciscospark.com/v1/messages?roomId=" + rooms.items[active_room].id);

            /* json will look like:
             * {
             *   "items": [
             *     {
             *       "id": "Y2lzY29zcGFyazovL3Vz...",
             *       "roomId": "Control System Programmers",
             *       "roomType": "group",
             *       "text": false,
             *       "personId": "Y2lzY29zcGFyazovL3Vz...",
             *       "personEmail": "klofstrand@spscom.com",
             *       "created": "2016-07-12T21:24:20.684Z"
             *     },
             *     ...
             *   ]
             * }
             */
            messages = JsonConvert.DeserializeObject<SparkMessageCollection>(json);

            lstMessages.Items.Clear();

            foreach (SparkMessage m in messages.items)
            {
                lstMessages.Items.Add(m.text);
            }
        }

        private void lstMessages_DoubleClick(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo();
            f.Msg = messages.items[lstMessages.SelectedIndex];
            f.Show();
        }
    }

    public class SparkRoom
    {
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public bool isLocked { get; set; }
        public DateTime created { get; set; }
        public DateTime lastActivity { get; set; }
    }

    public class SparkMessage
    {
        public string id { get; set; }
        public string roomId { get; set; }
        public string roomType { get; set; }
        public string text { get; set; }
        public string personId { get; set; }
        public string personEmail { get; set; }
        public DateTime created { get; set; }
    }

    public class SparkRoomCollection
    {
        public List<SparkRoom> items { get; set; }
    }

    public class SparkMessageCollection
    {
        public List<SparkMessage> items { get; set; }
    }
}
