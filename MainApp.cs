using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProxyIpTools.Core;
using XS.Core;
using ProxyIpTools.Core.Entity; 

namespace ProxyIpTools
{
    public partial class MainApp : Form
    { 
         
        public MainApp()
        {
            InitializeComponent();
            //this.TopMost = true;
         
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += MainApp_FormClosing;

            ThreadPoolManager.Init(10);
              
            #region 初始


            lvData.View = View.Details;//只有设置为这个HeaderStyle才有用
            lvData.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvData.GridLines = true;//显示网格线
            lvData.FullRowSelect = true;//选择时选择是行，而不是某列
            lvData.Columns.Add("Id", 0, HorizontalAlignment.Left);
            lvData.Columns.Add("检测地址", 200, HorizontalAlignment.Left);
            lvData.Columns.Add("代理地址", 200, HorizontalAlignment.Left);
            lvData.Columns.Add("端口", 100, HorizontalAlignment.Left);
            lvData.Columns.Add("是否有效", 80, HorizontalAlignment.Left);
            lvData.Columns.Add("响应时间", 100, HorizontalAlignment.Left);
            lvData.Columns.Add("最后报告", 500, HorizontalAlignment.Left);

            //winform中，listview是没有办法设置行高的，没行之间排得密密麻麻的，很不好！

            //可以加入一个imagelist来 撑大 行，实现行高的设置！

            //   设置行高   20   
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);//分别是宽和高
            lvData.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大

            lvApis.View = View.Details;//只有设置为这个HeaderStyle才有用
            lvApis.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvApis.GridLines = true;//显示网格线
            lvApis.FullRowSelect = true;//选择时选择是行，而不是某列
            lvApis.Columns.Add("Id", 0, HorizontalAlignment.Left);
            lvApis.Columns.Add("API", 500, HorizontalAlignment.Left);
            lvApis.SmallImageList = imgList;

            lvIps.View = View.Details;//只有设置为这个HeaderStyle才有用
            lvIps.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvIps.GridLines = true;//显示网格线
            lvIps.FullRowSelect = true;//选择时选择是行，而不是某列
            lvIps.Columns.Add("Id", 0, HorizontalAlignment.Left);
            lvIps.Columns.Add("Ip", 200, HorizontalAlignment.Left);
            lvIps.Columns.Add("端口", 100, HorizontalAlignment.Left);
            //lvIps.Columns.Add("是否有效", 100, HorizontalAlignment.Left);
            //lvIps.Columns.Add("响应时间", 100, HorizontalAlignment.Left);
            lvIps.SmallImageList = imgList;

            lvTestUrls.View = View.Details;//只有设置为这个HeaderStyle才有用
            lvTestUrls.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvTestUrls.GridLines = true;//显示网格线
            lvTestUrls.FullRowSelect = true;//选择时选择是行，而不是某列
            lvTestUrls.Columns.Add("Id", 80, HorizontalAlignment.Left);
            lvTestUrls.Columns.Add("名称", 120, HorizontalAlignment.Left);
            lvTestUrls.Columns.Add("测试地址", 350, HorizontalAlignment.Left);
            lvTestUrls.Columns.Add("验证字符", 100, HorizontalAlignment.Left); 
            lvTestUrls.SmallImageList = imgList;



            #endregion

            #region 回调

            dlgUpdateItem = delegate(UrlIpsForOk model, int CurrentValue)
            {
                BindUrlIpForOkItem(model);
                proBar.Value = CurrentValue;
                if(proBar.Value== proBar.Maximum)
                    btnGetIpForUsed.Enabled = true;
            };

            CompCheck = delegate(UrlIpsForOk model,int CurrentValue)
            {
                Core.Dal.UrlIpsForOk.Instane.Add(model);
                lvData.Invoke(dlgUpdateItem, model, CurrentValue);
                
            };
            #endregion

            this.Show();
            this.Activate();
            BindDataApis();
            BindDataTestUrls();
            BindIps();
            BindUrlIpForOk();
        }

        private delegate void UpdateItem(Core.Entity.UrlIpsForOk model, int CurrentValue);
        private UpdateItem dlgUpdateItem;

        public void BindDataApis()
        {
            lvApis.Items.Clear();

            var lst = Core.Dal.Apis.Instane.GetAll();

            foreach (var model in lst)
            {
                ListViewItem li = new ListViewItem();
                li.Text = model.Id.ToString(); 
                li.SubItems.Add(model.Url);
                lvApis.Items.Add(li);
            }
        }
        public void BindDataTestUrls()
        {
            lvTestUrls.Items.Clear();
            var lst = Core.Dal.TestUrls.Instane.GetAll();

            foreach (var model in lst)
            {
                ListViewItem li = new ListViewItem();
                li.Text = model.Id.ToString(); 
                li.SubItems.Add(model.TestName);
                li.SubItems.Add(model.Url);
                li.SubItems.Add(model.CheckStr);
                lvTestUrls.Items.Add(li);
            }
        }
        public void BindIps()
        {
            lvIps.Items.Clear();
            var lst = Core.Dal.Ips.Instane.GetAll();

            foreach (var model in lst)
            {
                ListViewItem li = new ListViewItem();
                li.Text = model.Id.ToString();
                li.SubItems.Add(model.Ip);
                li.SubItems.Add(model.Port.ToString());
                
                lvIps.Items.Add(li);
            }
        }

        public void BindUrlIpForOk()
        {
            lvData.Items.Clear();
            var lst = Core.Dal.UrlIpsForOk.Instane.GetAll();
            //lvData.Columns.Add("检测地址", 200, HorizontalAlignment.Left);
            //lvData.Columns.Add("代理IP", 200, HorizontalAlignment.Left);
            //lvData.Columns.Add("端口", 100, HorizontalAlignment.Left);
            //lvData.Columns.Add("是否有效", 80, HorizontalAlignment.Left);
            //lvData.Columns.Add("验证字符", 100, HorizontalAlignment.Left);
            //lvData.Columns.Add("最后报告", 500, HorizontalAlignment.Left);
            foreach (var model in lst)
            {
                BindUrlIpForOkItem(model);
            }
        }

        public void BindUrlIpForOkItem(Core.Entity.UrlIpsForOk model)
        {
            ListViewItem li = new ListViewItem();
            li.Text = model.Id.ToString();
            li.SubItems.Add(model.Url);
            li.SubItems.Add(model.Ip);
            li.SubItems.Add(model.Port.ToString());
            if (model.IsOk == 0)
            {
                li.SubItems.Add("无效");
                li.BackColor = Color.Gold;
            }
            else
            {
                li.SubItems.Add("有效");
            }
            li.SubItems.Add(XS.Core.DateUtils.MillisecondToTime(model.Times));
            li.SubItems.Add(model.Report);
            lvData.Items.Add(li);
        }

        #region 上下文菜单操作


            private void lvData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.lvData.SelectedItems.Count > 0)
                {
                    Point p = new Point();
                    p.X = e.Location.X;
                    p.Y = e.Location.Y - 30;

                    this.cmuIISLog.Show(this, p);
                }
            }
            //lbsPartName.Visible = false;
        }
          

        #endregion
         
         

        private void 查看未来执行时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                string sId = lvData.SelectedItems[0].Text; 
            }
            else
            {
                MessageBox.Show("请选择一个任务！");
            }
           

        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (MessageBox.Show("退出后将终止所有任务，您确认退出吗？", "退出程序", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // 关闭所有的线程
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确认要删除此任务吗？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sId = lvData.SelectedItems[0].Text;
                     
                     
                }
               
            }
            else
            {
                MessageBox.Show("请选择一个任务！");
            }
            
        }
         

        private void btnAddApi_Click(object sender, EventArgs e)
        {
            AddApis frm = new AddApis(this,0);
            frm.ShowDialog();
        }

        private void btnAddTestUrl_Click(object sender, EventArgs e)
        {
            AddTestUrl frm = new AddTestUrl(this,0);
            frm.ShowDialog();
        }

        private void btnAddProxyIp_Click(object sender, EventArgs e)
        {
            AddIps frm = new AddIps(this);
            frm.ShowDialog();
        }

        private void btnClearIp_Click(object sender, EventArgs e)
        {
            Core.Dal.Ips.Instane.DelIpForBad();
            this.BindIps();
        }

        private Action<Core.Entity.UrlIpsForOk,int> CompCheck;
        private void btnGetIpForUsed_Click(object sender, EventArgs e)
        {
            if (lvTestUrls.SelectedItems.Count > 0)
            {
                btnGetIpForUsed.Enabled = false;

                List<Core.Entity.TestUrls> lstUrls = new List<Core.Entity.TestUrls>();

                foreach (ListViewItem li in lvTestUrls.SelectedItems)
                {
                    lstUrls.Add(Core.Dal.TestUrls.Instane.GetEntity(int.Parse(li.Text)));
                }

                var lstIps = Core.Dal.Ips.Instane.GetAll();
                proBar.Maximum = lstIps.Count;
                Thread th = new Thread(() =>
                {
                    //var lstUrls = Core.Dal.TestUrls.Instane.GetAll();

                    int iCount = 0;
                    foreach (var mdIp in lstIps)
                    {
                        iCount++;
                        foreach (var mdTestUrl in lstUrls)
                        {

                            var rzData = GetSiteStr(mdIp.Ip, mdIp.Port, mdTestUrl.Url, mdTestUrl.CheckStr);
                            Core.Entity.UrlIpsForOk model = new UrlIpsForOk();
                            model.UrlId = mdTestUrl.Id;
                            model.Url = mdTestUrl.Url;
                            model.IpId = mdIp.Id;
                            model.Ip = mdIp.Ip;
                            model.Port = mdIp.Port;
                            model.IsOk = rzData.Item1 ? 1 : 0;
                            model.Times = rzData.Item2;
                            model.Report = rzData.Item3;
                            model.MdWuIpPort = mdIp.MdWu;
                            if (!Equals(CompCheck, null))
                            {
                                CompCheck(model, iCount);
                            }
                        }

                    }

                });
                th.Start();
            }
            else
            {
                MessageBox.Show("请至少要选择一个测试地址！");
            }
            
        }
        public Tuple<bool,int,string> GetSiteStr(string Ip,int Port,string sUrl,string CheckStr)
        {
            XS.Core.RunTimeWatch rtw = new RunTimeWatch();
            rtw.start();
            bool isOk = false;
            string sRz = string.Empty;
            try
            {
                System.Net.WebProxy proxyObject = new System.Net.WebProxy(Ip, Port);//str为IP地址 port为端口号 代理类
                System.Net.HttpWebRequest Req = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(sUrl); // 访问这个网站 ，返回的就是你发出请求的代理ip 这个做代理ip测试非常方便，可以知道代理是否成功

                Req.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; QQWubi 133; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; CIBA; InfoPath.2)";

                Req.Proxy = proxyObject; //设置代理 
                Req.Method = "GET";
                Req.Timeout = Setting.Instance.TimeOut;
                System.Net.HttpWebResponse Resp = (System.Net.HttpWebResponse)Req.GetResponse();
                Encoding code = Encoding.Default;
                 
                using (System.IO.StreamReader sr = new System.IO.StreamReader(Resp.GetResponseStream(), code))
                {
                    string returns = sr.ReadToEnd();//获取得到的网址html返回数据，这里就可以使用某些解析html的dll直接使用了,比如htmlpaser 
                    if (!string.IsNullOrEmpty(returns))
                    {
                        if (returns.IndexOf(CheckStr) > -1)
                        {
                            sRz = string.Format("验证成功,{0}", DateTime.Now);
                            isOk = true;
                        }
                        else
                        {
                            sRz = string.Format("验证失败,{0}", DateTime.Now);
                        }
                    }
                    else
                    {
                        sRz = string.Format("远程接口无返回值,{0}", DateTime.Now);
                    }
                        

                }
                Resp.Close(); 
            }
            catch (Exception ex)
            {
                isOk = false;
                sRz = string.Format("调用远程接口发生异常:{0},{1}", ex.Message, DateTime.Now);
            }
             
            return new Tuple<bool, int,string>(isOk, rtw.endmillisecond(), sRz);
            //return XS.Core.WebUtils.GetHtml(sUrl);
        }

        private void btnRefeshIp_Click(object sender, EventArgs e)
        {

            //var lstApis = Core.Dal.Apis.Instane.GetAll();
            //foreach (var model in lstApis)
            //{
            //   string sContent = XS.Core.WebUtils.LoadURLString(model.Url);

                
            //}
            
        }

        private void btnDelSelIP_Click(object sender, EventArgs e)
        {
            if (lvIps.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvIps.SelectedItems)
                {
                    Core.Dal.Ips.Instane.DeleteModel(int.Parse(item.Text));
                }

                BindIps();
            }
            else
            {
                MessageBox.Show("请选择IP");
            }
        }

        private void btnClearAllIp_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvData.SelectedItems)
                {
                    Core.Dal.UrlIpsForOk.Instane.DeleteModel(int.Parse(item.Text));
                }

                BindUrlIpForOk();
            }
            else
            {
                MessageBox.Show("请选择至少一条数据");
            }
        }
    }
}
