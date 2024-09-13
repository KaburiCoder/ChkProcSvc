
namespace ChkProc
{
  partial class MainView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
      this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
      this.txtSvcStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.label2 = new System.Windows.Forms.Label();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnExit = new DevComponents.DotNetBar.ButtonX();
      this.btnDelSvc = new DevComponents.DotNetBar.ButtonX();
      this.btnStopSvc = new DevComponents.DotNetBar.ButtonX();
      this.btnStartSvc = new DevComponents.DotNetBar.ButtonX();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
      this.txtOutput = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.label1 = new System.Windows.Forms.Label();
      this.svcTimer = new System.Windows.Forms.Timer(this.components);
      this.setListCtrl = new ChkProc.Feature.Main.UI.SettingListControl();
      this.panelEx1.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panelEx3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelEx1
      // 
      this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx1.Controls.Add(this.txtSvcStatus);
      this.panelEx1.Controls.Add(this.label2);
      this.panelEx1.Controls.Add(this.flowLayoutPanel2);
      this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelEx1.Location = new System.Drawing.Point(0, 0);
      this.panelEx1.Name = "panelEx1";
      this.panelEx1.Padding = new System.Windows.Forms.Padding(4);
      this.panelEx1.Size = new System.Drawing.Size(822, 50);
      this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
      this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.panelEx1.Style.GradientAngle = 90;
      this.panelEx1.TabIndex = 2;
      // 
      // txtSvcStatus
      // 
      this.txtSvcStatus.BackColor = System.Drawing.Color.White;
      // 
      // 
      // 
      this.txtSvcStatus.Border.Class = "TextBoxBorder";
      this.txtSvcStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.txtSvcStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSvcStatus.Location = new System.Drawing.Point(87, 15);
      this.txtSvcStatus.Name = "txtSvcStatus";
      this.txtSvcStatus.PreventEnterBeep = true;
      this.txtSvcStatus.ReadOnly = true;
      this.txtSvcStatus.Size = new System.Drawing.Size(122, 21);
      this.txtSvcStatus.TabIndex = 12;
      this.txtSvcStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 12);
      this.label2.TabIndex = 11;
      this.label2.Text = "서비스 상태";
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.btnExit);
      this.flowLayoutPanel2.Controls.Add(this.btnDelSvc);
      this.flowLayoutPanel2.Controls.Add(this.btnStopSvc);
      this.flowLayoutPanel2.Controls.Add(this.btnStartSvc);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
      this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(460, 4);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(358, 42);
      this.flowLayoutPanel2.TabIndex = 10;
      // 
      // btnExit
      // 
      this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnExit.Location = new System.Drawing.Point(272, 3);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(83, 37);
      this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnExit.Symbol = "";
      this.btnExit.SymbolSize = 12F;
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "종료";
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnDelSvc
      // 
      this.btnDelSvc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnDelSvc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnDelSvc.Location = new System.Drawing.Point(183, 3);
      this.btnDelSvc.Name = "btnDelSvc";
      this.btnDelSvc.Size = new System.Drawing.Size(83, 36);
      this.btnDelSvc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnDelSvc.SymbolSize = 12F;
      this.btnDelSvc.TabIndex = 11;
      this.btnDelSvc.Text = "서비스 삭제";
      this.btnDelSvc.Click += new System.EventHandler(this.btnDelSvc_Click);
      // 
      // btnStopSvc
      // 
      this.btnStopSvc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnStopSvc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnStopSvc.Location = new System.Drawing.Point(94, 3);
      this.btnStopSvc.Name = "btnStopSvc";
      this.btnStopSvc.Size = new System.Drawing.Size(83, 37);
      this.btnStopSvc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnStopSvc.SymbolSize = 12F;
      this.btnStopSvc.TabIndex = 10;
      this.btnStopSvc.Text = "서비스 중지";
      this.btnStopSvc.Click += new System.EventHandler(this.btnStopSvc_Click);
      // 
      // btnStartSvc
      // 
      this.btnStartSvc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnStartSvc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnStartSvc.Location = new System.Drawing.Point(5, 3);
      this.btnStartSvc.Name = "btnStartSvc";
      this.btnStartSvc.Size = new System.Drawing.Size(83, 36);
      this.btnStartSvc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnStartSvc.SymbolSize = 12F;
      this.btnStartSvc.TabIndex = 7;
      this.btnStartSvc.Text = "서비스 실행";
      this.btnStartSvc.Click += new System.EventHandler(this.btnStartSvc_Click);
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter1.Location = new System.Drawing.Point(0, 248);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(822, 8);
      this.splitter1.TabIndex = 29;
      this.splitter1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.setListCtrl);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 50);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(822, 198);
      this.panel1.TabIndex = 33;
      // 
      // panelEx3
      // 
      this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx3.Controls.Add(this.txtOutput);
      this.panelEx3.Controls.Add(this.label1);
      this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelEx3.Location = new System.Drawing.Point(0, 256);
      this.panelEx3.Name = "panelEx3";
      this.panelEx3.Padding = new System.Windows.Forms.Padding(4);
      this.panelEx3.Size = new System.Drawing.Size(822, 258);
      this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
      this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.panelEx3.Style.GradientAngle = 90;
      this.panelEx3.TabIndex = 34;
      this.panelEx3.Text = "panelEx3";
      // 
      // txtOutput
      // 
      this.txtOutput.BackColor = System.Drawing.SystemColors.HighlightText;
      // 
      // 
      // 
      this.txtOutput.Border.Class = "TextBoxBorder";
      this.txtOutput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOutput.Location = new System.Drawing.Point(4, 20);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.PreventEnterBeep = true;
      this.txtOutput.ReadOnly = true;
      this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtOutput.Size = new System.Drawing.Size(814, 234);
      this.txtOutput.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(4, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(814, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "Output";
      // 
      // svcTimer
      // 
      this.svcTimer.Enabled = true;
      this.svcTimer.Tick += new System.EventHandler(this.svcTimer_Tick);
      // 
      // setListCtrl
      // 
      this.setListCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.setListCtrl.Location = new System.Drawing.Point(0, 0);
      this.setListCtrl.Name = "setListCtrl";
      this.setListCtrl.Size = new System.Drawing.Size(822, 198);
      this.setListCtrl.TabIndex = 41;
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(822, 514);
      this.Controls.Add(this.panelEx3);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panelEx1);
      this.DoubleBuffered = true;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "서비스 관리 (ServiceName: ChkProcSvc)";
      this.panelEx1.ResumeLayout(false);
      this.panelEx1.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panelEx3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private DevComponents.DotNetBar.PanelEx panelEx1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private DevComponents.DotNetBar.ButtonX btnExit;
    private DevComponents.DotNetBar.ButtonX btnStopSvc;
    private DevComponents.DotNetBar.ButtonX btnStartSvc;
    private DevComponents.DotNetBar.ButtonX btnDelSvc;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panel1;
    private Feature.Main.UI.SettingListControl setListCtrl;
    private DevComponents.DotNetBar.PanelEx panelEx3;
    private DevComponents.DotNetBar.Controls.TextBoxX txtOutput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Timer svcTimer;
    private DevComponents.DotNetBar.Controls.TextBoxX txtSvcStatus;
    private System.Windows.Forms.Label label2;
  }
}