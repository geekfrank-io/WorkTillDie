namespace WorkTillDie
{
    partial class FormMain
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GVTimeLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCRecord = new DevExpress.XtraGrid.GridControl();
            this.GVRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaysOfWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingSpan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtraTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinutes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnShow = new DevExpress.XtraBars.BarButtonItem();
            this.btnHide = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ckAutoStart = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LBLExtraOfMonth = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.GVTimeLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckAutoStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBLExtraOfMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // GVTimeLogs
            // 
            this.GVTimeLogs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colValue,
            this.colNote});
            this.GVTimeLogs.GridControl = this.GCRecord;
            this.GVTimeLogs.Name = "GVTimeLogs";
            this.GVTimeLogs.OptionsBehavior.ReadOnly = true;
            this.GVTimeLogs.OptionsView.ShowColumnHeaders = false;
            this.GVTimeLogs.OptionsView.ShowGroupPanel = false;
            // 
            // colValue
            // 
            this.colValue.Caption = "Value";
            this.colValue.FieldName = "Value";
            this.colValue.MinWidth = 25;
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 0;
            this.colValue.Width = 593;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.MinWidth = 25;
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            this.colNote.Width = 186;
            // 
            // GCRecord
            // 
            gridLevelNode1.LevelTemplate = this.GVTimeLogs;
            gridLevelNode1.RelationName = "TimeLogs";
            this.GCRecord.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GCRecord.Location = new System.Drawing.Point(16, 48);
            this.GCRecord.MainView = this.GVRecord;
            this.GCRecord.MenuManager = this.barManager1;
            this.GCRecord.Name = "GCRecord";
            this.GCRecord.Size = new System.Drawing.Size(919, 499);
            this.GCRecord.TabIndex = 8;
            this.GCRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVRecord,
            this.GVTimeLogs});
            // 
            // GVRecord
            // 
            this.GVRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colDaysOfWeek,
            this.ColStartTime,
            this.colEndTime,
            this.colWorkingSpan,
            this.colExtraTime,
            this.colMinutes});
            this.GVRecord.GridControl = this.GCRecord;
            this.GVRecord.Name = "GVRecord";
            this.GVRecord.OptionsBehavior.ReadOnly = true;
            this.GVRecord.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 94;
            // 
            // colDaysOfWeek
            // 
            this.colDaysOfWeek.Caption = "Day Of Week";
            this.colDaysOfWeek.FieldName = "DayOfWeek";
            this.colDaysOfWeek.MinWidth = 25;
            this.colDaysOfWeek.Name = "colDaysOfWeek";
            this.colDaysOfWeek.Visible = true;
            this.colDaysOfWeek.VisibleIndex = 1;
            this.colDaysOfWeek.Width = 94;
            // 
            // ColStartTime
            // 
            this.ColStartTime.Caption = "Start Time";
            this.ColStartTime.FieldName = "StartValue";
            this.ColStartTime.MinWidth = 25;
            this.ColStartTime.Name = "ColStartTime";
            this.ColStartTime.Visible = true;
            this.ColStartTime.VisibleIndex = 2;
            this.ColStartTime.Width = 94;
            // 
            // colEndTime
            // 
            this.colEndTime.Caption = "End Time";
            this.colEndTime.FieldName = "EndValue";
            this.colEndTime.MinWidth = 25;
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 3;
            this.colEndTime.Width = 94;
            // 
            // colWorkingSpan
            // 
            this.colWorkingSpan.Caption = "Working";
            this.colWorkingSpan.FieldName = "WorkingSpan";
            this.colWorkingSpan.MinWidth = 25;
            this.colWorkingSpan.Name = "colWorkingSpan";
            this.colWorkingSpan.Visible = true;
            this.colWorkingSpan.VisibleIndex = 4;
            this.colWorkingSpan.Width = 94;
            // 
            // colExtraTime
            // 
            this.colExtraTime.Caption = "Extra Time";
            this.colExtraTime.FieldName = "ExtraTime";
            this.colExtraTime.MinWidth = 25;
            this.colExtraTime.Name = "colExtraTime";
            this.colExtraTime.Visible = true;
            this.colExtraTime.VisibleIndex = 6;
            this.colExtraTime.Width = 94;
            // 
            // colMinutes
            // 
            this.colMinutes.Caption = "Extra Minutes";
            this.colMinutes.FieldName = "ExtraMinutes";
            this.colMinutes.MinWidth = 25;
            this.colMinutes.Name = "colMinutes";
            this.colMinutes.Visible = true;
            this.colMinutes.VisibleIndex = 5;
            this.colMinutes.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnShow,
            this.btnHide,
            this.btnExit,
            this.barHeaderItem1});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 577);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 577);
            // 
            // btnShow
            // 
            this.btnShow.Caption = "Show";
            this.btnShow.Id = 0;
            this.btnShow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShow.ImageOptions.SvgImage")));
            this.btnShow.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnShow.Name = "btnShow";
            this.btnShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShow_ItemClick);
            // 
            // btnHide
            // 
            this.btnHide.Caption = "Hide";
            this.btnHide.Id = 1;
            this.btnHide.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHide.ImageOptions.SvgImage")));
            this.btnHide.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnHide.Name = "btnHide";
            this.btnHide.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHide_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 2;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Working Time";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.barHeaderItem1.Tag = "Working Time";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShow),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHide),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // alertControl1
            // 
            this.alertControl1.PopupMenu = this.popupMenu1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(941, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 34);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GCRecord);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.ckAutoStart);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1068, 287, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1007, 577);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(941, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 34);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            // 
            // ckAutoStart
            // 
            this.ckAutoStart.Location = new System.Drawing.Point(16, 16);
            this.ckAutoStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckAutoStart.Name = "ckAutoStart";
            this.ckAutoStart.Properties.Caption = "Auto Start";
            this.ckAutoStart.Size = new System.Drawing.Size(185, 26);
            this.ckAutoStart.StyleController = this.layoutControl1;
            this.ckAutoStart.TabIndex = 6;
            this.ckAutoStart.CheckedChanged += new System.EventHandler(this.ckAutoStart_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.LBLExtraOfMonth,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1007, 577);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ckAutoStart;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(191, 32);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAdd;
            this.layoutControlItem4.Location = new System.Drawing.Point(925, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(56, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnDelete;
            this.layoutControlItem1.Location = new System.Drawing.Point(925, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(56, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 537);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(925, 14);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(925, 80);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(56, 471);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GCRecord;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(925, 505);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // LBLExtraOfMonth
            // 
            this.LBLExtraOfMonth.AllowHotTrack = false;
            this.LBLExtraOfMonth.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LBLExtraOfMonth.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LBLExtraOfMonth.Location = new System.Drawing.Point(715, 0);
            this.LBLExtraOfMonth.Name = "LBLExtraOfMonth";
            this.LBLExtraOfMonth.Size = new System.Drawing.Size(210, 32);
            this.LBLExtraOfMonth.Tag = "Month: ";
            this.LBLExtraOfMonth.Text = "Time:";
            this.LBLExtraOfMonth.TextSize = new System.Drawing.Size(38, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(191, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(524, 32);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 577);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormMain.IconOptions.Image")));
            this.LookAndFeel.SkinName = "WXI";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVTimeLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckAutoStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBLExtraOfMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnShow;
        private DevExpress.XtraBars.BarButtonItem btnHide;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        //private DevExpress.XtraGrid.GridControl GCRecords;
        //private DevExpress.XtraGrid.Views.Grid.GridView GVRecords;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysOfWeek;
        private DevExpress.XtraGrid.Columns.GridColumn ColStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colMinutes;
        private DevExpress.XtraGrid.Columns.GridColumn colExtraTime;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingSpan;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.CheckEdit ckAutoStart;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.GridControl GCRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView GVTimeLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView GVRecord;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleLabelItem LBLExtraOfMonth;
    }
}