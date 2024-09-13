using ChkProcLib.Helpers;
using ChkProcLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ChkProc.Feature.RequiredSvc.UI
{
  public partial class RequiredSvcControl : UserControl
  {
    public event EventHandler OnClose;
    readonly List<RequiredService> services;
    readonly CheckInfo info;

    public RequiredSvcControl(CheckInfo info)
    {
      InitializeComponent();
      this.info = info;

      lbxAll.DisplayMember = "DisplayName";
      lbxAll.ValueMember = "ServiceName";
       
      lbxCur.DisplayMember = "DisplayName";
      lbxCur.ValueMember = "ServiceName";
      services = ServiceHelper.GetServices()
        .OrderBy(x => x.DisplayName)
        .Select(x => new RequiredService { DisplayName = x.DisplayName, ServiceName = x.ServiceName })
        .ToList();


      SetLbxCur();
      SetLbxAll();
    }

    private void SetLbxAll()
    {
      string search = txtSearch.Text.Trim();

      lbxAll.Items.Clear();
      var foundServices = string.IsNullOrEmpty(search)
        ? services
        : services.FindAll(x => x.DisplayName.ToLower().Contains(search.ToLower()) || x.ServiceName.ToLower().Contains(search.ToLower())
      );

      lbxAll.Items.AddRange(foundServices.ToArray());
    }

    private void SetLbxCur()
    {
      info.RequiredServices.ForEach(svc =>
      {
        lbxCur.Items.Add(svc);
      });
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      OnClose?.Invoke(this, e);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
      SetLbxAll();
    }

    private void lbxAll_DoubleClick(object sender, EventArgs e)
    {
      var selectedSvc = lbxAll.SelectedItem as RequiredService;

      if (!info.RequiredServices.Any(x => x.ServiceName.ToLower() == selectedSvc.ServiceName.ToLower()))
      {
        info.RequiredServices.Add(selectedSvc);
        lbxCur.Items.Add(selectedSvc);
      }
    }

    private void lbxCur_KeyDown(object sender, KeyEventArgs e)
    {
      var selectedSvc = lbxCur.SelectedItem as RequiredService;
      if (selectedSvc == null) return;

      info.RequiredServices.Remove(selectedSvc);
      lbxCur.Items.Remove(selectedSvc);
    }     
  }
}
