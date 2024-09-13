
namespace ChkProc.Feature.Main.UI
{
  partial class SettingControl
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
      this.components = new System.ComponentModel.Container();
      this.txtFullPath = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.iiSec = new DevComponents.Editors.IntegerInput();
      this.label4 = new System.Windows.Forms.Label();
      this.btnDel = new DevComponents.DotNetBar.ButtonX();
      this.btnNavToLogs = new DevComponents.DotNetBar.ButtonX();
      this.btnRequired = new DevComponents.DotNetBar.ButtonX();
      this.flyRequiredSvc = new DevComponents.DotNetBar.Controls.Flyout(this.components);
      this.lblTime = new System.Windows.Forms.Label();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iiSec)).BeginInit();
      this.SuspendLayout();
      // 
      // txtFullPath
      // 
      this.txtFullPath.BackColor = System.Drawing.Color.White;
      // 
      // 
      // 
      this.txtFullPath.Border.Class = "TextBoxBorder";
      this.txtFullPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.txtFullPath.ButtonCustom.Text = "..";
      this.txtFullPath.ButtonCustom.Visible = true;
      this.txtFullPath.Location = new System.Drawing.Point(62, 3);
      this.txtFullPath.Name = "txtFullPath";
      this.txtFullPath.PreventEnterBeep = true;
      this.txtFullPath.Size = new System.Drawing.Size(294, 21);
      this.txtFullPath.TabIndex = 0;
      this.txtFullPath.ButtonCustomClick += new System.EventHandler(this.txtFullPath_ButtonCustomClick);
      this.txtFullPath.TextChanged += new System.EventHandler(this.txtFullPath_TextChanged);
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.label1);
      this.flowLayoutPanel1.Controls.Add(this.txtFullPath);
      this.flowLayoutPanel1.Controls.Add(this.label2);
      this.flowLayoutPanel1.Controls.Add(this.label3);
      this.flowLayoutPanel1.Controls.Add(this.iiSec);
      this.flowLayoutPanel1.Controls.Add(this.label4);
      this.flowLayoutPanel1.Controls.Add(this.lblTime);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(689, 27);
      this.flowLayoutPanel1.TabIndex = 1;
      this.flowLayoutPanel1.WrapContents = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 8);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "파일경로";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(362, 8);
      this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 12);
      this.label2.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(368, 8);
      this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 12);
      this.label3.TabIndex = 4;
      this.label3.Text = "체크 간격";
      // 
      // iiSec
      // 
      // 
      // 
      // 
      this.iiSec.BackgroundStyle.Class = "DateTimeInputBackground";
      this.iiSec.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.iiSec.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
      this.iiSec.Location = new System.Drawing.Point(431, 3);
      this.iiSec.MinValue = 1;
      this.iiSec.Name = "iiSec";
      this.iiSec.ShowUpDown = true;
      this.iiSec.Size = new System.Drawing.Size(85, 21);
      this.iiSec.TabIndex = 3;
      this.iiSec.Value = 1;
      this.iiSec.ValueChanged += new System.EventHandler(this.iiSec_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(522, 8);
      this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(17, 12);
      this.label4.TabIndex = 5;
      this.label4.Text = "초";
      // 
      // btnDel
      // 
      this.btnDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnDel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
      this.btnDel.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnDel.Location = new System.Drawing.Point(759, 0);
      this.btnDel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new System.Drawing.Size(35, 27);
      this.btnDel.Symbol = "";
      this.btnDel.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.btnDel.SymbolSize = 15F;
      this.btnDel.TabIndex = 6;
      this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
      // 
      // btnNavToLogs
      // 
      this.btnNavToLogs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnNavToLogs.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
      this.btnNavToLogs.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnNavToLogs.Location = new System.Drawing.Point(724, 0);
      this.btnNavToLogs.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.btnNavToLogs.Name = "btnNavToLogs";
      this.btnNavToLogs.Size = new System.Drawing.Size(35, 27);
      this.btnNavToLogs.Symbol = "";
      this.btnNavToLogs.SymbolColor = System.Drawing.SystemColors.HotTrack;
      this.btnNavToLogs.SymbolSize = 15F;
      this.btnNavToLogs.TabIndex = 7;
      this.btnNavToLogs.Click += new System.EventHandler(this.btnNavToLogs_Click);
      // 
      // btnRequired
      // 
      this.btnRequired.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.btnRequired.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
      this.btnRequired.Dock = System.Windows.Forms.DockStyle.Right;
      this.btnRequired.Location = new System.Drawing.Point(689, 0);
      this.btnRequired.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
      this.btnRequired.Name = "btnRequired";
      this.btnRequired.Size = new System.Drawing.Size(35, 27);
      this.btnRequired.Symbol = "";
      this.btnRequired.SymbolColor = System.Drawing.SystemColors.HotTrack;
      this.btnRequired.SymbolSize = 15F;
      this.btnRequired.TabIndex = 8;
      this.btnRequired.Click += new System.EventHandler(this.btnRequired_Click);
      // 
      // flyRequiredSvc
      // 
      this.flyRequiredSvc.DisplayMode = DevComponents.DotNetBar.Controls.eFlyoutDisplayMode.Manual;
      this.flyRequiredSvc.DropShadow = false;
      this.flyRequiredSvc.Parent = this;
      this.flyRequiredSvc.TargetControl = this.btnRequired;
      this.flyRequiredSvc.FlyoutClosed += new System.Windows.Forms.FormClosedEventHandler(this.flyRequiredSvc_FlyoutClosed);
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.ForeColor = System.Drawing.Color.Gray;
      this.lblTime.Location = new System.Drawing.Point(545, 8);
      this.lblTime.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(67, 12);
      this.lblTime.TabIndex = 6;
      this.lblTime.Text = "0시 0분 0초";
      // 
      // SettingControl
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.btnRequired);
      this.Controls.Add(this.btnNavToLogs);
      this.Controls.Add(this.btnDel);
      this.Name = "SettingControl";
      this.Size = new System.Drawing.Size(794, 27);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SettingControl_DragDrop);
      this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SettingControl_DragEnter);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iiSec)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevComponents.DotNetBar.Controls.TextBoxX txtFullPath;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private DevComponents.Editors.IntegerInput iiSec;
    private System.Windows.Forms.Label label4;
    private DevComponents.DotNetBar.ButtonX btnDel;
    private DevComponents.DotNetBar.ButtonX btnNavToLogs;
    private DevComponents.DotNetBar.ButtonX btnRequired;
    private DevComponents.DotNetBar.Controls.Flyout flyRequiredSvc;
    private System.Windows.Forms.Label lblTime;
  }
}
