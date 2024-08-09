using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WorkTillDie
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            AddRecordWhenAutoStart();
        }


        private void LoadData()
        {
            DateTime[] dates = UtilsCommon.GetInstance().getAllRecordsOfEveryday();
            GCRecords.DataSource = dates;

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
            Logger.WriteInfo("Add record: " + time.ToString());
        }


        /// <summary>
        /// 前天第一次启动时，自动添加时间记录
        /// </summary>
        private void AddRecordWhenAutoStart()
        {
            DateTime[] records = UtilsCommon.GetInstance().getAllRecordsOfTheDay(DateTime.Now);
            if (records == null)
            {
                AddRecord();
            }
        }

        private void btnHide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();                      //隐藏窗体 
        }

        private void btnShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowWindow();
        }

        private void ShowWindow()
        {

            this.Show();                                //窗体显示  
            this.WindowState = FormWindowState.Normal;  //窗体状态默认大小  
            this.Activate();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            LoadData();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(MousePosition);
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BeforeExist();
        }

        private void BeforeExist()
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Sure to exist?", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddRecord();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}