namespace ProxyIpTools
{
    partial class AddIps
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIps = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入IP，一行一个，如 ：79.154.171.14:8080";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIps
            // 
            this.txtIps.Location = new System.Drawing.Point(12, 29);
            this.txtIps.Name = "txtIps";
            this.txtIps.Size = new System.Drawing.Size(278, 151);
            this.txtIps.TabIndex = 13;
            this.txtIps.Text = "";
            // 
            // AddIps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 232);
            this.Controls.Add(this.txtIps);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "AddIps";
            this.Text = "添加任务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtIps;
    }
}