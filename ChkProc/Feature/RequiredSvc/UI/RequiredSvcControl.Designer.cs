
namespace ChkProc.Feature.RequiredSvc.UI
{
  partial class RequiredSvcControl
  {
    /// <summary> 
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region 구성 요소 디자이너에서 생성한 코드

    /// <summary> 
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
      this.btnExit = new DevComponents.DotNetBar.ButtonX();
      this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
      this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
      this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.lbxAll = new System.Windows.Forms.ListBox();
      this.lbxCur = new System.Windows.Forms.ListBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.labelX1 = new DevComponents.DotNetBar.LabelX();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.labelX2 = new DevComponents.DotNetBar.LabelX();
      this.labelX3 = new DevComponents.DotNetBar.LabelX();
      this.panelEx1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelEx1
      // 
      this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx1.Controls.Add(this.btnExit);
      this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelEx1.Location = new System.Drawing.Point(0, 0);
      this.panelEx1.Name = "panelEx1";
      this.panelEx1.Size = new System.Drawing.Size(542, 40);
      this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
      this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
      this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
      this.panelEx1.Style.ForeColor.Color = System.Drawing.Color.White;
      this.panelEx1.Style.GradientAngle = 90;
      this.panelEx1.TabIndex = 0;
      this.panelEx1.Text = "먼저 실행되야하는 서비스를 등록합니다.\r\n(해당 서비스가 실행 상태가 아니면 자동 실행하지 않아요.)";
      // 
      // btnExit
      // 
      this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnExit.Location = new System.Drawing.Point(451, 2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(90, 35);
      this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "닫기";
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // panelEx2
      // 
      this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx2.Location = new System.Drawing.Point(6, 46);
      this.panelEx2.Name = "panelEx2";
      this.panelEx2.Size = new System.Drawing.Size(262, 33);
      this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
      this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx2.Style.ForeColor.Color = System.Drawing.Color.White;
      this.panelEx2.Style.GradientAngle = 90;
      this.panelEx2.TabIndex = 4;
      this.panelEx2.Text = "전체 서비스";
      // 
      // panelEx3
      // 
      this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx3.Location = new System.Drawing.Point(274, 46);
      this.panelEx3.Name = "panelEx3";
      this.panelEx3.Size = new System.Drawing.Size(262, 33);
      this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
      this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx3.Style.ForeColor.Color = System.Drawing.Color.White;
      this.panelEx3.Style.GradientAngle = 90;
      this.panelEx3.TabIndex = 11;
      this.panelEx3.Text = "등록 서비스";
      // 
      // txtSearch
      // 
      // 
      // 
      // 
      this.txtSearch.Border.Class = "TextBoxBorder";
      this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.txtSearch.Location = new System.Drawing.Point(6, 85);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.PreventEnterBeep = true;
      this.txtSearch.Size = new System.Drawing.Size(262, 21);
      this.txtSearch.TabIndex = 14;
      this.txtSearch.WatermarkText = "검색..";
      this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
      // 
      // lbxAll
      // 
      this.lbxAll.FormattingEnabled = true;
      this.lbxAll.ItemHeight = 12;
      this.lbxAll.Location = new System.Drawing.Point(6, 112);
      this.lbxAll.Name = "lbxAll";
      this.lbxAll.Size = new System.Drawing.Size(262, 268);
      this.lbxAll.TabIndex = 24;
      this.lbxAll.DoubleClick += new System.EventHandler(this.lbxAll_DoubleClick);
      // 
      // lbxCur
      // 
      this.lbxCur.FormattingEnabled = true;
      this.lbxCur.ItemHeight = 12;
      this.lbxCur.Location = new System.Drawing.Point(274, 112);
      this.lbxCur.Name = "lbxCur";
      this.lbxCur.Size = new System.Drawing.Size(262, 268);
      this.lbxCur.TabIndex = 34;
      this.lbxCur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxCur_KeyDown);
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.groupBox1.Controls.Add(this.labelX1);
      this.groupBox1.ForeColor = System.Drawing.Color.White;
      this.groupBox1.Location = new System.Drawing.Point(6, 386);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(262, 100);
      this.groupBox1.TabIndex = 44;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Info";
      // 
      // labelX1
      // 
      this.labelX1.AutoSize = true;
      // 
      // 
      // 
      this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelX1.ForeColor = System.Drawing.Color.White;
      this.labelX1.Location = new System.Drawing.Point(3, 17);
      this.labelX1.Name = "labelX1";
      this.labelX1.Size = new System.Drawing.Size(210, 30);
      this.labelX1.TabIndex = 0;
      this.labelX1.Text = "※ 전체 서비스에서 등록하고자 하는 서비스를 <b>더블클릭</b>하세요";
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.groupBox2.Controls.Add(this.labelX2);
      this.groupBox2.Controls.Add(this.labelX3);
      this.groupBox2.ForeColor = System.Drawing.Color.White;
      this.groupBox2.Location = new System.Drawing.Point(274, 386);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(262, 100);
      this.groupBox2.TabIndex = 54;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Info";
      // 
      // labelX2
      // 
      // 
      // 
      // 
      this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelX2.ForeColor = System.Drawing.Color.White;
      this.labelX2.Location = new System.Drawing.Point(3, 51);
      this.labelX2.Name = "labelX2";
      this.labelX2.Size = new System.Drawing.Size(256, 34);
      this.labelX2.TabIndex = 6;
      this.labelX2.Text = "※ 모두 추가했으면 닫기 후 설정 저장해주세요.";
      this.labelX2.WordWrap = true;
      // 
      // labelX3
      // 
      // 
      // 
      // 
      this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelX3.ForeColor = System.Drawing.Color.White;
      this.labelX3.Location = new System.Drawing.Point(3, 17);
      this.labelX3.Name = "labelX3";
      this.labelX3.Size = new System.Drawing.Size(256, 34);
      this.labelX3.TabIndex = 5;
      this.labelX3.Text = "※ 등록 서비스를 지우시려면 선택 후 `<font color=\"#ED1C24\"><b>Del</b></font>`키를 누르세요.";
      this.labelX3.WordWrap = true;
      // 
      // RequiredSvcControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lbxCur);
      this.Controls.Add(this.lbxAll);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.panelEx3);
      this.Controls.Add(this.panelEx2);
      this.Controls.Add(this.panelEx1);
      this.Name = "RequiredSvcControl";
      this.Size = new System.Drawing.Size(542, 489);
      this.panelEx1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevComponents.DotNetBar.PanelEx panelEx1;
    private DevComponents.DotNetBar.PanelEx panelEx2;
    private DevComponents.DotNetBar.PanelEx panelEx3;
    private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
    private DevComponents.DotNetBar.ButtonX btnExit;
    private System.Windows.Forms.ListBox lbxAll;
    private System.Windows.Forms.ListBox lbxCur;
    private System.Windows.Forms.GroupBox groupBox1;
    private DevComponents.DotNetBar.LabelX labelX1;
    private System.Windows.Forms.GroupBox groupBox2;
    private DevComponents.DotNetBar.LabelX labelX2;
    private DevComponents.DotNetBar.LabelX labelX3;
  }
}
