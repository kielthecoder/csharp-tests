using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkClient1
{
    public partial class frmInfo : Form
    {
        private SparkMessage _msg;

        public SparkMessage Msg
        {
            get
            {
                return _msg;
            }
            set
            {
                _msg = value;

                txtMessage.Text = _msg.text;
            }
        }

        public frmInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
