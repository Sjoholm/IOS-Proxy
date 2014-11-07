using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iOS_Proxy
{
    public partial class frmInspect : Form
    {
        public frmInspect(string request, string response)
        {
            InitializeComponent();

            rbRequest.Text = request;
            rbResponse.Text = response;
        }
    }
}
