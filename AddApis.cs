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
    public partial class AddApis : Form
    {
        private int Id = 0;
        private MainApp _frmMain;
        public AddApis(MainApp frmMain,int TastId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Id = TastId;
            _frmMain = frmMain;
            //使最大化窗口失效
            this.MaximizeBox = false;
            //下一句用来禁止对窗口大小进行拖拽
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            
             
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            Core.Entity.Apis model = new Core.Entity.Apis() ;
            model.Url = txtUrl.Text.Trim();
            ProxyIpTools.Core.Dal.Apis.Instane.Add(model);
            _frmMain.BindDataApis();
             
        }
         
    }
}
