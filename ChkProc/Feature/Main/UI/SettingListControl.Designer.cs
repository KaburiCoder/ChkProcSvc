
namespace ChkProc.Feature.Main.UI
{
  partial class SettingListControl
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
      this.flpnl = new System.Windows.Forms.FlowLayoutPanel();
      this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
      this.btnAddNew = new DevComponents.DotNetBar.ButtonX();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnSaveSettings = new DevComponents.DotNetBar.ButtonX();
      this.panelEx1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // flpnl
      // 
      this.flpnl.AllowDrop = true;
      this.flpnl.AutoScroll = true;
      this.flpnl.BackColor = System.Drawing.Color.White;
      this.flpnl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpnl.Location = new System.Drawing.Point(0, 0);
      this.flpnl.Name = "flpnl";
      this.flpnl.Size = new System.Drawing.Size(691, 338);
      this.flpnl.TabIndex = 34;
      // 
      // panelEx1
      // 
      this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
      this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.panelEx1.Controls.Add(this.tableLayoutPanel1);
      this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
      this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelEx1.Location = new System.Drawing.Point(0, 338);
      this.panelEx1.Name = "panelEx1";
      this.panelEx1.Size = new System.Drawing.Size(691, 38);
      this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
      this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top;
      this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.panelEx1.Style.GradientAngle = 90;
      this.panelEx1.TabIndex = 35;
      // 
      // btnAddNew
      // 
      this.btnAddNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnAddNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnAddNew.Location = new System.Drawing.Point(3, 3);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(339, 32);
      this.btnAddNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnAddNew.Symbol = "";
      this.btnAddNew.SymbolSize = 12F;
      this.btnAddNew.TabIndex = 7;
      this.btnAddNew.Text = "항목 추가";
      this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.btnSaveSettings, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnAddNew, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 38);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // btnSaveSettings
      // 
      this.btnSaveSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnSaveSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnSaveSettings.Location = new System.Drawing.Point(348, 3);
      this.btnSaveSettings.Name = "btnSaveSettings";
      this.btnSaveSettings.Size = new System.Drawing.Size(340, 32);
      this.btnSaveSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.btnSaveSettings.Symbol = "";
      this.btnSaveSettings.SymbolSize = 12F;
      this.btnSaveSettings.TabIndex = 12;
      this.btnSaveSettings.Text = "설정 저장";
      this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
      // 
      // SettingListControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.flpnl);
      this.Controls.Add(this.panelEx1);
      this.Name = "SettingListControl";
      this.Size = new System.Drawing.Size(691, 376);
      this.panelEx1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flpnl;
    private DevComponents.DotNetBar.PanelEx panelEx1;
    private DevComponents.DotNetBar.ButtonX btnAddNew;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private DevComponents.DotNetBar.ButtonX btnSaveSettings;
  }
}
