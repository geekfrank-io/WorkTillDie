using System;
using System.Windows.Forms;

namespace WorkTillDie
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            AddRecordWhenAutoStart();
        }


        private void ckAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAutoStart.Checked)
            {
                UtilsAutoStart.SetMeStart(true);
            }
            else
            {
                UtilsAutoStart.SetMeStart(false);
            }
        }


        private void AddRecord()
        {
            DateTime time = DateTime.Now;
            UtilsCommon.GetInstance().AddRecord(time);
        }


        /// <summary>
        /// 前天第一次启动时，自动添加时间记录
        /// </summary>
        private void AddRecordWhenAutoStart()
        {
            DateTime[] records = UtilsCommon.GetInstance().getAllRecordsOfTheDay(DateTime.Now);
            if (records == null)
                UtilsCommon.GetInstance().AddRecord(DateTime.Now);
        }

        private void btnHide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();                      //隐藏窗体 
        }

        private void btnShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Show();                                //窗体显示  
            this.WindowState = FormWindowState.Normal;  //窗体状态默认大小  
            this.Activate();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
        }
    }
}