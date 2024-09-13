using ChkProc.Feature.RequiredSvc.UI;
using ChkProc.Shared.Router;
using ChkProcLib.Helpers;
using ChkProcLib.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChkProc.Feature.Main.UI
{
  public partial class SettingControl : UserControl
  {
    public event Action<SettingControl> OnDelete;

    private readonly CheckInfo info;
    private readonly CheckInfo prevInfo;
    private RequiredSvcControl _svcControl;
    private RequiredSvcControl SvcControl
    {
      get
      {
        if (_svcControl == null)
        {
          _svcControl = new RequiredSvcControl(info);
          _svcControl.OnClose += (_, __) => flyRequiredSvc.Close();
        }
        return _svcControl;
      }
    }

    public SettingControl(CheckInfo info)
    {
      this.info = info;
      prevInfo = info.DeepCopy();
      InitializeComponent();

      txtFullPath.Text = info.FullPath.Trim();
      iiSec.Value = info.Sec;
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      OnDelete?.Invoke(this);
    }

    private void DisplayChangeItems()
    {
      bool isPathChanged = info.FullPath.ToLower() != prevInfo.FullPath.ToLower();
      bool isSecChanged = info.Sec != prevInfo.Sec;
      bool isRequiredSvcChanged = info.RequiredServices.Count != prevInfo.RequiredServices.Count
        || !info.RequiredServices.All(info =>
            prevInfo.RequiredServices.Any(pinfo => info.ServiceName.ToLower() == pinfo.ServiceName.ToLower())); 

      this.BackColor = isPathChanged || isSecChanged || isRequiredSvcChanged ? Color.LightPink : Color.White;

      txtFullPath.ForeColor = isPathChanged ? Color.HotPink : Color.Black;
      iiSec.ForeColor = isSecChanged ? Color.HotPink : Color.Black;

      // 시간 포맷팅
      lblTime.Text = FormatHelper.FormatTime(info.Sec);
    }

    private void txtFullPath_TextChanged(object sender, EventArgs e)
    {
      info.FullPath = txtFullPath.Text.Trim();
      DisplayChangeItems();
    }

    private void iiSec_ValueChanged(object sender, EventArgs e)
    {
      info.Sec = iiSec.Value;
      DisplayChangeItems();
    }

    private void SettingControl_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        e.Effect = DragDropEffects.Copy; // 드롭을 허용
      }
      else
      {
        e.Effect = DragDropEffects.None; // 드롭을 허용하지 않음
      }
    }

    private void SettingControl_DragDrop(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        // 드롭된 파일들의 경로를 가져옴
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        // 파일 경로를 텍스트박스에 추가
        txtFullPath.Text = string.Join(Environment.NewLine, files);
      }
    }

    private void txtFullPath_ButtonCustomClick(object sender, EventArgs e)
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.InitialDirectory = "C:\\";
        openFileDialog.Filter = "모든 파일 (*.*)|*.*|exe 파일 (*.exe)|*.exe";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        // 다이얼로그를 표시하고 사용자가 파일을 선택하면
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          // 선택된 파일의 경로를 텍스트박스에 표시
          txtFullPath.Text = openFileDialog.FileName;
        }
      }
    }

    private void btnNavToLogs_Click(object sender, EventArgs e)
    {
      Router.ShowLogView(prevInfo.ProcessName);
    }

    private void btnRequired_Click(object sender, EventArgs e)
    {
      flyRequiredSvc.Content = SvcControl;
      flyRequiredSvc.Show(sender);
    }

    private void flyRequiredSvc_FlyoutClosed(object sender, FormClosedEventArgs e)
    {
      DisplayChangeItems();
    }
  }
}
