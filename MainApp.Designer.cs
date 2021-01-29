namespace ProxyIpTools
{
    partial class MainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.cmuIISLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.继续运行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看未来执行时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvApis = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddApi = new System.Windows.Forms.ToolStripButton();
            this.btnRefeshIp = new System.Windows.Forms.ToolStripButton();
            this.lvIps = new System.Windows.Forms.ListView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddProxyIp = new System.Windows.Forms.ToolStripButton();
            this.btnClearIp = new System.Windows.Forms.ToolStripButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lvTestUrls = new System.Windows.Forms.ListView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnAddTestUrl = new System.Windows.Forms.ToolStripButton();
            this.lvData = new System.Windows.Forms.ListView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnGetIpForUsed = new System.Windows.Forms.ToolStripButton();
            this.proBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnClearAllIp = new System.Windows.Forms.ToolStripButton();
            this.btnDelSelIP = new System.Windows.Forms.ToolStripButton();
            this.cmuIISLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmuIISLog
            // 
            this.cmuIISLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.暂停任务ToolStripMenuItem,
            this.继续运行ToolStripMenuItem,
            this.启动ToolStripMenuItem,
            this.查看未来执行时间ToolStripMenuItem});
            this.cmuIISLog.Name = "cmuIISLog";
            this.cmuIISLog.Size = new System.Drawing.Size(149, 136);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 暂停任务ToolStripMenuItem
            // 
            this.暂停任务ToolStripMenuItem.Name = "暂停任务ToolStripMenuItem";
            this.暂停任务ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.暂停任务ToolStripMenuItem.Text = "暂停任务";
            // 
            // 继续运行ToolStripMenuItem
            // 
            this.继续运行ToolStripMenuItem.Name = "继续运行ToolStripMenuItem";
            this.继续运行ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.继续运行ToolStripMenuItem.Text = "继续运行";
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.启动ToolStripMenuItem.Text = "启动";
            // 
            // 查看未来执行时间ToolStripMenuItem
            // 
            this.查看未来执行时间ToolStripMenuItem.Name = "查看未来执行时间ToolStripMenuItem";
            this.查看未来执行时间ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看未来执行时间ToolStripMenuItem.Text = "未来执行时间";
            this.查看未来执行时间ToolStripMenuItem.Click += new System.EventHandler(this.查看未来执行时间ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(953, 643);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvApis);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lvIps);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(414, 643);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvApis
            // 
            this.lvApis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvApis.Location = new System.Drawing.Point(0, 25);
            this.lvApis.Name = "lvApis";
            this.lvApis.Size = new System.Drawing.Size(414, 188);
            this.lvApis.TabIndex = 1;
            this.lvApis.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddApi,
            this.btnRefeshIp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(414, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddApi
            // 
            this.btnAddApi.Image = global::ProxyIpTools.Properties.Resources.add;
            this.btnAddApi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddApi.Name = "btnAddApi";
            this.btnAddApi.Size = new System.Drawing.Size(95, 22);
            this.btnAddApi.Text = "添加代理API";
            this.btnAddApi.Click += new System.EventHandler(this.btnAddApi_Click);
            // 
            // btnRefeshIp
            // 
            this.btnRefeshIp.Image = global::ProxyIpTools.Properties.Resources.sort;
            this.btnRefeshIp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefeshIp.Name = "btnRefeshIp";
            this.btnRefeshIp.Size = new System.Drawing.Size(63, 22);
            this.btnRefeshIp.Text = "刷新IP";
            this.btnRefeshIp.Click += new System.EventHandler(this.btnRefeshIp_Click);
            // 
            // lvIps
            // 
            this.lvIps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIps.Location = new System.Drawing.Point(0, 25);
            this.lvIps.Name = "lvIps";
            this.lvIps.Size = new System.Drawing.Size(414, 401);
            this.lvIps.TabIndex = 2;
            this.lvIps.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProxyIp,
            this.btnClearIp,
            this.btnDelSelIP});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(414, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddProxyIp
            // 
            this.btnAddProxyIp.Image = global::ProxyIpTools.Properties.Resources.add;
            this.btnAddProxyIp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddProxyIp.Name = "btnAddProxyIp";
            this.btnAddProxyIp.Size = new System.Drawing.Size(87, 22);
            this.btnAddProxyIp.Text = "添加代理IP";
            this.btnAddProxyIp.Click += new System.EventHandler(this.btnAddProxyIp_Click);
            // 
            // btnClearIp
            // 
            this.btnClearIp.Image = global::ProxyIpTools.Properties.Resources.stop2;
            this.btnClearIp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearIp.Name = "btnClearIp";
            this.btnClearIp.Size = new System.Drawing.Size(87, 22);
            this.btnClearIp.Text = "清空无效IP";
            this.btnClearIp.Click += new System.EventHandler(this.btnClearIp_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lvTestUrls);
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lvData);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip4);
            this.splitContainer3.Size = new System.Drawing.Size(535, 643);
            this.splitContainer3.SplitterDistance = 213;
            this.splitContainer3.TabIndex = 0;
            // 
            // lvTestUrls
            // 
            this.lvTestUrls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTestUrls.Location = new System.Drawing.Point(0, 25);
            this.lvTestUrls.Name = "lvTestUrls";
            this.lvTestUrls.Size = new System.Drawing.Size(535, 188);
            this.lvTestUrls.TabIndex = 2;
            this.lvTestUrls.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTestUrl});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(535, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnAddTestUrl
            // 
            this.btnAddTestUrl.Image = global::ProxyIpTools.Properties.Resources.add;
            this.btnAddTestUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTestUrl.Name = "btnAddTestUrl";
            this.btnAddTestUrl.Size = new System.Drawing.Size(100, 22);
            this.btnAddTestUrl.Text = "添加测试地址";
            this.btnAddTestUrl.Click += new System.EventHandler(this.btnAddTestUrl_Click);
            // 
            // lvData
            // 
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.Location = new System.Drawing.Point(0, 25);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(535, 401);
            this.lvData.TabIndex = 3;
            this.lvData.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGetIpForUsed,
            this.proBar,
            this.btnSettings,
            this.btnClearAllIp});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(535, 25);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btnGetIpForUsed
            // 
            this.btnGetIpForUsed.Image = global::ProxyIpTools.Properties.Resources.start;
            this.btnGetIpForUsed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetIpForUsed.Name = "btnGetIpForUsed";
            this.btnGetIpForUsed.Size = new System.Drawing.Size(87, 22);
            this.btnGetIpForUsed.Text = "检测有效IP";
            this.btnGetIpForUsed.Click += new System.EventHandler(this.btnGetIpForUsed_Click);
            // 
            // proBar
            // 
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(200, 22);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::ProxyIpTools.Properties.Resources.setting;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(52, 22);
            this.btnSettings.Text = "设置";
            // 
            // btnClearAllIp
            // 
            this.btnClearAllIp.Image = global::ProxyIpTools.Properties.Resources.Pause;
            this.btnClearAllIp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAllIp.Name = "btnClearAllIp";
            this.btnClearAllIp.Size = new System.Drawing.Size(76, 22);
            this.btnClearAllIp.Text = "删除所选";
            this.btnClearAllIp.Click += new System.EventHandler(this.btnClearAllIp_Click);
            // 
            // btnDelSelIP
            // 
            this.btnDelSelIP.Image = global::ProxyIpTools.Properties.Resources.Pause;
            this.btnDelSelIP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelSelIP.Name = "btnDelSelIP";
            this.btnDelSelIP.Size = new System.Drawing.Size(87, 22);
            this.btnDelSelIP.Text = "删除所选IP";
            this.btnDelSelIP.Click += new System.EventHandler(this.btnDelSelIP_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 647);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApp";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Text = "亿伯任务管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainApp_FormClosed);
            this.cmuIISLog.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion 
        private System.Windows.Forms.ContextMenuStrip cmuIISLog;  
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 继续运行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看未来执行时间ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddProxyIp;
        private System.Windows.Forms.ToolStripButton btnAddApi;
        private System.Windows.Forms.ToolStripButton btnRefeshIp;
        private System.Windows.Forms.ToolStripButton btnClearIp;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnAddTestUrl;
        private System.Windows.Forms.ListView lvIps;
        private System.Windows.Forms.ListView lvTestUrls;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ListView lvApis;
        private System.Windows.Forms.ToolStripButton btnGetIpForUsed;
        private System.Windows.Forms.ToolStripProgressBar proBar;
        private System.Windows.Forms.ToolStripButton btnClearAllIp;
        private System.Windows.Forms.ToolStripButton btnDelSelIP;
    }
}