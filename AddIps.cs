using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XS.DataProfile.Log;

namespace ProxyIpTools
{
    public partial class AddIps : Form
    { 
        private MainApp _frmMain;
        public AddIps(MainApp frmMain)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
            _frmMain = frmMain;
            //使最大化窗口失效
            this.MaximizeBox = false;
            //下一句用来禁止对窗口大小进行拖拽
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            
             
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sMsg = txtIps.Text.Trim();
            if (!string.IsNullOrEmpty(sMsg))
            {
                int iBadCount = 0;
                string[] aIps = XS.Core.Strings.GetString.GetArrByWrap(sMsg);
                foreach (string ip in aIps)
                {
                    string[] aip = ip.Split(':');
                    if (aip.Length == 2)
                    {
                        Core.Entity.Ips model = new Core.Entity.Ips();
                        model.Ip = aip[0];
                        model.Port = Int32.Parse(aip[1]);
                        //model.IsOk = -1;
                        if (!Core.Dal.Ips.Instane.Add(model))
                        {
                            iBadCount++;
                        }
                    }

                }

                _frmMain.BindIps();

                if (iBadCount > 0)
                {
                    MessageBox.Show(string.Format("重复数据{0}条",iBadCount));
                }
            }
            else
            {
                MessageBox.Show("请输入IP！");
            }
            
             
        }
         
    }
}
