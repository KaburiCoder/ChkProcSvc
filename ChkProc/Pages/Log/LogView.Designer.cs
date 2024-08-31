
namespace ChkProc.Pages
{
  partial class LogView
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
      this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
      this.chkInactiveGraph = new DevComponents.DotNetBar.Controls.CheckBoxX();
      this.chkInfinite = new DevComponents.DotNetBar.Controls.CheckBoxX();
      this.btnSearch = new DevComponents.DotNetBar.ButtonX();
      this.btnExit = new DevComponents.DotNetBar.ButtonX();
      this.labelX3 = new DevComponents.DotNetBar.LabelX();
      this.dtiE = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
      this.dtiS = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
      this.labelX2 = new DevComponents.DotNetBar.LabelX();
      this.labelX1 = new DevComponents.DotNetBar.LabelX();
      this.cmbProcess = new DevComponents.DotNetBar.Controls.ComboBoxEx();
      this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.infiniteTimer = new System.Windows.Forms.Timer(this.components);
      this.panelEx1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtiE)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtiS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // panelEx1
      // 
      this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx1.Controls.Add(this.chkInactiveGraph);
      this.panelEx1.Controls.Add(this.chkInfinite);
      this.panelEx1.Controls.Add(this.btnSearch);
      this.panelEx1.Controls.Add(this.btnExit);
      this.panelEx1.Controls.Add(this.labelX3);
      this.panelEx1.Controls.Add(this.dtiE);
      this.panelEx1.Controls.Add(this.dtiS);
      this.panelEx1.Controls.Add(this.labelX2);
      this.panelEx1.Controls.Add(this.labelX1);
      this.panelEx1.Controls.Add(this.cmbProcess);
      this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelEx1.Location = new System.Drawing.Point(0, 0);
      this.panelEx1.Name = "panelEx1";
      this.panelEx1.Size = new System.Drawing.Size(904, 49);
      this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
      this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.panelEx1.Style.GradientAngle = 90;
      this.panelEx1.TabIndex = 0;
      // 
      // chkInactiveGraph
      // 
      this.chkInactiveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      // 
      // 
      // 
      this.chkInactiveGraph.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.chkInactiveGraph.Location = new System.Drawing.Point(614, 24);
      this.chkInactiveGraph.Name = "chkInactiveGraph";
      this.chkInactiveGraph.Size = new System.Drawing.Size(114, 23);
      this.chkInactiveGraph.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.chkInactiveGraph.TabIndex = 14;
      this.chkInactiveGraph.Text = "Inactive Graph";
      this.chkInactiveGraph.CheckedChanged += new System.EventHandler(this.chkInactiveGraph_CheckedChanged);
      // 
      // chkInfinite
      // 
      this.chkInfinite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      // 
      // 
      // 
      this.chkInfinite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.chkInfinite.Location = new System.Drawing.Point(614, 1);
      this.chkInfinite.Name = "chkInfinite";
      this.chkInfinite.Size = new System.Drawing.Size(114, 23);
      this.chkInfinite.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.chkInfinite.TabIndex = 12;
      this.chkInfinite.Text = "실시간 조회";
      this.chkInfinite.CheckedChanged += new System.EventHandler(this.chkInfinite_CheckedChanged);
      // 
      // btnSearch
      // 
      this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnSearch.Location = new System.Drawing.Point(734, 2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(83, 45);
      this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnSearch.Symbol = "";
      this.btnSearch.SymbolSize = 12F;
      this.btnSearch.TabIndex = 11;
      this.btnSearch.Text = "조회";
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnExit
      // 
      this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnExit.Location = new System.Drawing.Point(819, 2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(83, 45);
      this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnExit.Symbol = "";
      this.btnExit.SymbolSize = 12F;
      this.btnExit.TabIndex = 10;
      this.btnExit.Text = "종료";
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // labelX3
      // 
      this.labelX3.AutoSize = true;
      // 
      // 
      // 
      this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX3.Location = new System.Drawing.Point(361, 17);
      this.labelX3.Name = "labelX3";
      this.labelX3.Size = new System.Drawing.Size(16, 16);
      this.labelX3.TabIndex = 5;
      this.labelX3.Text = "~";
      // 
      // dtiE
      // 
      this.dtiE.AllowEmptyState = false;
      // 
      // 
      // 
      this.dtiE.BackgroundStyle.Class = "DateTimeInputBackground";
      this.dtiE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiE.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
      this.dtiE.ButtonDropDown.Visible = true;
      this.dtiE.CustomFormat = "yyyy-MM-dd";
      this.dtiE.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
      this.dtiE.IsPopupCalendarOpen = false;
      this.dtiE.Location = new System.Drawing.Point(383, 13);
      // 
      // 
      // 
      // 
      // 
      // 
      this.dtiE.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiE.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
      this.dtiE.MonthCalendar.ClearButtonVisible = true;
      // 
      // 
      // 
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
      this.dtiE.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiE.MonthCalendar.DisplayMonth = new System.DateTime(2024, 8, 1, 0, 0, 0, 0);
      // 
      // 
      // 
      this.dtiE.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.dtiE.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
      this.dtiE.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.dtiE.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiE.MonthCalendar.TodayButtonVisible = true;
      this.dtiE.Name = "dtiE";
      this.dtiE.Size = new System.Drawing.Size(117, 21);
      this.dtiE.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.dtiE.TabIndex = 4;
      // 
      // dtiS
      // 
      this.dtiS.AllowEmptyState = false;
      // 
      // 
      // 
      this.dtiS.BackgroundStyle.Class = "DateTimeInputBackground";
      this.dtiS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiS.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
      this.dtiS.ButtonDropDown.Visible = true;
      this.dtiS.CustomFormat = "yyyy-MM-dd";
      this.dtiS.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
      this.dtiS.IsPopupCalendarOpen = false;
      this.dtiS.Location = new System.Drawing.Point(238, 13);
      // 
      // 
      // 
      // 
      // 
      // 
      this.dtiS.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiS.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
      this.dtiS.MonthCalendar.ClearButtonVisible = true;
      // 
      // 
      // 
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
      this.dtiS.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiS.MonthCalendar.DisplayMonth = new System.DateTime(2024, 8, 1, 0, 0, 0, 0);
      // 
      // 
      // 
      this.dtiS.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.dtiS.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
      this.dtiS.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.dtiS.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.dtiS.MonthCalendar.TodayButtonVisible = true;
      this.dtiS.Name = "dtiS";
      this.dtiS.Size = new System.Drawing.Size(117, 21);
      this.dtiS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.dtiS.TabIndex = 3;
      // 
      // labelX2
      // 
      this.labelX2.AutoSize = true;
      // 
      // 
      // 
      this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX2.Location = new System.Drawing.Point(201, 15);
      this.labelX2.Name = "labelX2";
      this.labelX2.Size = new System.Drawing.Size(31, 18);
      this.labelX2.TabIndex = 2;
      this.labelX2.Text = "기간";
      // 
      // labelX1
      // 
      this.labelX1.AutoSize = true;
      // 
      // 
      // 
      this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX1.Location = new System.Drawing.Point(12, 15);
      this.labelX1.Name = "labelX1";
      this.labelX1.Size = new System.Drawing.Size(56, 18);
      this.labelX1.TabIndex = 1;
      this.labelX1.Text = "프로세스";
      // 
      // cmbProcess
      // 
      this.cmbProcess.DisplayMember = "Value";
      this.cmbProcess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.cmbProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbProcess.FormattingEnabled = true;
      this.cmbProcess.ItemHeight = 16;
      this.cmbProcess.Location = new System.Drawing.Point(74, 13);
      this.cmbProcess.Name = "cmbProcess";
      this.cmbProcess.Size = new System.Drawing.Size(121, 22);
      this.cmbProcess.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.cmbProcess.TabIndex = 0;
      this.cmbProcess.ValueMember = "Key";
      // 
      // dgv
      // 
      this.dgv.AllowUserToAddRows = false;
      this.dgv.BackgroundColor = System.Drawing.Color.White;
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CreatedAt,
            this.ProcessName,
            this.Status,
            this.Message});
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
      this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
      this.dgv.Location = new System.Drawing.Point(0, 49);
      this.dgv.Name = "dgv";
      this.dgv.RowTemplate.Height = 23;
      this.dgv.Size = new System.Drawing.Size(904, 500);
      this.dgv.TabIndex = 4;
      this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
      // 
      // Id
      // 
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Width = 40;
      // 
      // CreatedAt
      // 
      this.CreatedAt.HeaderText = "CreatedAt";
      this.CreatedAt.Name = "CreatedAt";
      this.CreatedAt.ReadOnly = true;
      this.CreatedAt.Width = 120;
      // 
      // ProcessName
      // 
      this.ProcessName.HeaderText = "ProcessName";
      this.ProcessName.Name = "ProcessName";
      this.ProcessName.ReadOnly = true;
      // 
      // Status
      // 
      this.Status.HeaderText = "Status";
      this.Status.Name = "Status";
      this.Status.ReadOnly = true;
      // 
      // Message
      // 
      this.Message.HeaderText = "Message";
      this.Message.Name = "Message";
      this.Message.ReadOnly = true;
      this.Message.Width = 500;
      // 
      // infiniteTimer
      // 
      this.infiniteTimer.Interval = 5000;
      this.infiniteTimer.Tick += new System.EventHandler(this.infiniteTimer_Tick);
      // 
      // LogView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 549);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.panelEx1);
      this.DoubleBuffered = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "LogView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "로그 조회";
      this.panelEx1.ResumeLayout(false);
      this.panelEx1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtiE)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtiS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevComponents.DotNetBar.PanelEx panelEx1;
    private DevComponents.DotNetBar.LabelX labelX3;
    private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiE;
    private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiS;
    private DevComponents.DotNetBar.LabelX labelX2;
    private DevComponents.DotNetBar.LabelX labelX1;
    private DevComponents.DotNetBar.Controls.ComboBoxEx cmbProcess;
    private DevComponents.DotNetBar.ButtonX btnSearch;
    private DevComponents.DotNetBar.ButtonX btnExit;
    private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    private DevComponents.DotNetBar.Controls.CheckBoxX chkInfinite;
    private System.Windows.Forms.Timer infiniteTimer;
    private DevComponents.DotNetBar.Controls.CheckBoxX chkInactiveGraph;
  }
}