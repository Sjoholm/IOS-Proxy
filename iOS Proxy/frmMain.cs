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
    public partial class frmMain : Form
    {
        private FiddlerWrapper fiddlerWrapper;        
        public frmMain()
        {
            InitializeComponent();

            fiddlerWrapper = new FiddlerWrapper(FiddlerCallback, true, true);
        }

        public void FiddlerCallback(FiddlerSession fiddlerSession)
        {
            var action = new Action<FiddlerSession>(AddSessionToList);
            BeginInvoke(action, fiddlerSession);
        }

        private void AddSessionToList(FiddlerSession fiddlerSession)
        {
            dgvSessionList.Rows.Add(fiddlerSession.client_ip, fiddlerSession.url, fiddlerSession.method, fiddlerSession.requestContentType, fiddlerSession.requestBody, fiddlerSession.responseContentType, fiddlerSession.responseBody);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            fiddlerWrapper.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fiddlerWrapper.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            fiddlerWrapper.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void dgvSessionList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvrSession = dgvSessionList.Rows[e.RowIndex];
            string RespContType = dgvrSession.Cells["RespContType"].Value.ToString();
            string Response = dgvrSession.Cells["Response"].Value.ToString();
            if (RespContType.Contains("json") ||
                (RespContType.Contains("text/html") && Response.Contains("{")) ||
                (RespContType.Contains("text/plain") && Response.Contains("{")))
            {
                Response = JsonFormatter.PrettyPrint(Response);
            }
            Response = Response.Replace("&quot;", "\"");
            frmInspect inspect = new frmInspect(dgvrSession.Cells["Request"].Value.ToString(), Response);
            inspect.Show();
        }

        private void tbxURLFilter_TextChanged(object sender, EventArgs e)
        {
            fiddlerWrapper.Filter = tbxURLFilter.Text;
        }        
    }
}
