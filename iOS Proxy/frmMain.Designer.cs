namespace iOS_Proxy
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSessionList = new System.Windows.Forms.DataGridView();
            this.lblURLFilter = new System.Windows.Forms.Label();
            this.tbxURLFilter = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.ClientIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqContentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespContType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSessionList
            // 
            this.dgvSessionList.AllowUserToAddRows = false;
            this.dgvSessionList.AllowUserToDeleteRows = false;
            this.dgvSessionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSessionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIP,
            this.URL,
            this.Method,
            this.ReqContentType,
            this.Request,
            this.RespContType,
            this.Response});
            this.dgvSessionList.Location = new System.Drawing.Point(13, 40);
            this.dgvSessionList.Name = "dgvSessionList";
            this.dgvSessionList.ReadOnly = true;
            this.dgvSessionList.RowTemplate.Height = 24;
            this.dgvSessionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionList.Size = new System.Drawing.Size(1261, 437);
            this.dgvSessionList.TabIndex = 0;
            this.dgvSessionList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessionList_CellDoubleClick);
            // 
            // lblURLFilter
            // 
            this.lblURLFilter.AutoSize = true;
            this.lblURLFilter.Location = new System.Drawing.Point(13, 13);
            this.lblURLFilter.Name = "lblURLFilter";
            this.lblURLFilter.Size = new System.Drawing.Size(142, 17);
            this.lblURLFilter.TabIndex = 1;
            this.lblURLFilter.Text = "URL Filter (contains):";
            // 
            // tbxURLFilter
            // 
            this.tbxURLFilter.Location = new System.Drawing.Point(161, 10);
            this.tbxURLFilter.Name = "tbxURLFilter";
            this.tbxURLFilter.Size = new System.Drawing.Size(224, 22);
            this.tbxURLFilter.TabIndex = 2;
            this.tbxURLFilter.TextChanged += new System.EventHandler(this.tbxURLFilter_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(391, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(472, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ClientIP
            // 
            this.ClientIP.HeaderText = "Client IP";
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // ReqContentType
            // 
            this.ReqContentType.HeaderText = "Req. Content Type";
            this.ReqContentType.Name = "ReqContentType";
            this.ReqContentType.ReadOnly = true;
            // 
            // Request
            // 
            this.Request.HeaderText = "Request";
            this.Request.Name = "Request";
            this.Request.ReadOnly = true;
            // 
            // RespContType
            // 
            this.RespContType.HeaderText = "Resp. Content Type";
            this.RespContType.Name = "RespContType";
            this.RespContType.ReadOnly = true;
            // 
            // Response
            // 
            this.Response.HeaderText = "Response";
            this.Response.Name = "Response";
            this.Response.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 489);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxURLFilter);
            this.Controls.Add(this.lblURLFilter);
            this.Controls.Add(this.dgvSessionList);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSessionList;
        private System.Windows.Forms.Label lblURLFilter;
        private System.Windows.Forms.TextBox tbxURLFilter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqContentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespContType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Response;
    }
}

