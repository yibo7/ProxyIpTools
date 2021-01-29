using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyIpTools
{
    public partial class AddTestUrl : Form
    {
        private int Id = 0;
        private MainApp _frmMain;
        public AddTestUrl(MainApp frmMain,int TastId)
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
            Core.Entity.TestUrls model = new Core.Entity.TestUrls();
            model.Url = txtUrl.Text.Trim();
            model.CheckStr = txtCheckStr.Text;
            model.TestName = txtName.Text;
            ProxyIpTools.Core.Dal.TestUrls.Instane.Add(model);
            _frmMain.BindDataTestUrls(); 
             
        }
         
    }
}
