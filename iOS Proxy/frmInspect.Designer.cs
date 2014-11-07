namespace iOS_Proxy
{
    partial class frmInspect
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
            this.lblRequest = new System.Windows.Forms.Label();
            this.rbRequest = new System.Windows.Forms.RichTextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.rbResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(13, 13);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(65, 17);
            this.lblRequest.TabIndex = 0;
            this.lblRequest.Text = "Request:";
            // 
            // rbRequest
            // 
            this.rbRequest.Location = new System.Drawing.Point(16, 34);
            this.rbRequest.Name = "rbRequest";
            this.rbRequest.Size = new System.Drawing.Size(938, 163);
            this.rbRequest.TabIndex = 1;
            this.rbRequest.Text = "";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(13, 205);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(76, 17);
            this.lblResponse.TabIndex = 2;
            this.lblResponse.Text = "Response:";
            // 
            // rbResponse
            // 
            this.rbResponse.Location = new System.Drawing.Point(16, 225);
            this.rbResponse.Name = "rbResponse";
            this.rbResponse.Size = new System.Drawing.Size(938, 507);
            this.rbResponse.TabIndex = 3;
            this.rbResponse.Text = "";
            // 
            // frmInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 744);
            this.Controls.Add(this.rbResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.rbRequest);
            this.Controls.Add(this.lblRequest);
            this.Name = "frmInspect";
            this.Text = "frmInspect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.RichTextBox rbRequest;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.RichTextBox rbResponse;
    }
}