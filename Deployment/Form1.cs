using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deployment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbAuthenticationBy.DataSource = new List<string>()
            {
                "Authentication by SSH",
                "Authentication FTP username"
            };
            cbbAuthenticationBy.SelectedIndex = 0;
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            prBar.Value = 80;
        }
    }
}
