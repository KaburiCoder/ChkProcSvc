using ChkProcLib.Helpers;
using ChkProcLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChkProc.Feature.Main.UI
{
  public partial class SettingListControl : UserControl
  {
    private Dictionary<SettingControl, CheckInfo> infoDict = new Dictionary<SettingControl, CheckInfo>();
    private MainController cont;
    public SettingListControl()
    {
      InitializeComponent();
      this.Resize += SettingListControl_Resize;
    }

    private void SetControlsWidth()
    {
      foreach (var ctrl in infoDict.Keys)
      {
        ctrl.Width = Math.Max(this.Width - 26, 200);
      }
    }

    private void SettingListControl_Resize(object sender, EventArgs e)
    {
      SetControlsWidth();
    }

    private void LoadControls()
    {
      DeleteAllControls();
      foreach (var info in cont.GetCheckInfos())
      {
        AddControl(info);
      }
      AddNew();
    }

    public void SetController(MainController cont)
    {
      this.cont = cont;
      LoadControls();
    }

    public void Save()
    {      
      var values = infoDict.Values.Where(info => !string.IsNullOrEmpty(info.FullPath)).ToList() ;
      values.Reverse(); // dict가 역순으로 쌓여서 반전(그래야 기존 순서 유지)
      cont.SaveSettings(values);
    }

    private void AddControl(CheckInfo info)
    {
      var control = new SettingControl(info);

      control.OnDelete += Control_OnDelete;

      infoDict[control] = info;
      flpnl.Controls.Add(control);
    }

    public void AddNew()
    {
      AddControl(new CheckInfo());
      SetControlsWidth();
    }

    private void DeleteAllControls()
    {
      foreach (var ctrl in infoDict.Keys.ToList())
      {
        Control_OnDelete(ctrl);
      }
    }

    private void Control_OnDelete(SettingControl ctrl)
    {
      if (infoDict.TryGetValue(ctrl, out CheckInfo info))
      {
        flpnl.Controls.Remove(ctrl);
        infoDict.Remove(ctrl);
      }
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      AddNew();
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
      try
      {
        Save();
        MessageBox.Show("저장되었습니다.");
        LoadControls();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
