
namespace ChkProc.Feature.Log.UI
{
  partial class LogGraphControl
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
      this.iiMin = new DevComponents.Editors.IntegerInput();
      this.flpnlMinTerm = new System.Windows.Forms.FlowLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.iiMin)).BeginInit();
      this.flpnlMinTerm.SuspendLayout();
      this.SuspendLayout();
      // 
      // iiMin
      // 
      // 
      // 
      // 
      this.iiMin.BackgroundStyle.Class = "DateTimeInputBackground";
      this.iiMin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.iiMin.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
      this.iiMin.Location = new System.Drawing.Point(3, 3);
      this.iiMin.MinValue = 1;
      this.iiMin.Name = "iiMin";
      this.iiMin.ShowUpDown = true;
      this.iiMin.Size = new System.Drawing.Size(49, 21);
      this.iiMin.TabIndex = 4;
      this.iiMin.Value = 10;
      this.iiMin.ValueChanged += new System.EventHandler(this.iiMin_ValueChanged);
      // 
      // flpnlMinTerm
      // 
      this.flpnlMinTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.flpnlMinTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpnlMinTerm.Controls.Add(this.iiMin);
      this.flpnlMinTerm.Controls.Add(this.label1);
      this.flpnlMinTerm.Location = new System.Drawing.Point(464, 14);
      this.flpnlMinTerm.Name = "flpnlMinTerm";
      this.flpnlMinTerm.Size = new System.Drawing.Size(149, 28);
      this.flpnlMinTerm.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(58, 8);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "분 단위로 보기";
      // 
      // LogGraphControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.flpnlMinTerm);
      this.Name = "LogGraphControl";
      this.Size = new System.Drawing.Size(631, 429);
      ((System.ComponentModel.ISupportInitialize)(this.iiMin)).EndInit();
      this.flpnlMinTerm.ResumeLayout(false);
      this.flpnlMinTerm.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private DevComponents.Editors.IntegerInput iiMin;
    private System.Windows.Forms.FlowLayoutPanel flpnlMinTerm;
    private System.Windows.Forms.Label label1;
  }
}
