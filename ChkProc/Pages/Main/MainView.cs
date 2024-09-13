using ChkProc.Feature.Main;
using ChkProc.Shared.Interfaces;
using ChkProc.Shared.Router;
using ChkProcLib.Entities;
using ChkProcLib.Helpers;
using ChkProcLib.Services;
using DevComponents.DotNetBar;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ChkProc
{
  public partial class MainView : OfficeForm, IMain
  {
    private MainController cont;
    private ServiceStatus serviceStatus;
    private bool isLoading;
    public MainView()
    {
      InitializeComponent();

      SetWindowTitle();
    }

    private void SetWindowTitle()
    {
      // 어셈블리의 파일 버전 가져오기
      var version = Assembly.GetExecutingAssembly().GetName().Version;

      // 윈도우 제목 설정
      this.Text = $"서비스 관리 (ServiceName: ChkProcSvc) - v{version}";
    }

    public void SetController(MainController controller)
    {
      cont = controller;
      setListCtrl.SetController(cont);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnDelSvc_Click(object sender, EventArgs e)
    {
      cont.DeleteService();
    }

    private void btnStartSvc_Click(object sender, EventArgs e)
    {
      cont.StartService();
    }

    private void btnStopSvc_Click(object sender, EventArgs e)
    {
      cont.StopService();
    }

    public void SetIsLoading(bool isLoading)
    {
      InvokeCB(() =>
      {
        this.isLoading = isLoading;
        SetControlStatus();
      });
    }

    private void InvokeCB(Action action)
    {
      if (InvokeRequired)
      {
        BeginInvoke(action);
        return;
      }

      action.Invoke();
    }
    public void AddOutput(string message)
    {
      InvokeCB(() =>
      {
        message = (txtOutput.Text.Length > 0 ? "\r\n" : "") + message;
        txtOutput.AppendText(message);
        txtOutput.Top = txtOutput.Lines.Length;
      });
    }

    private void svcTimer_Tick(object sender, EventArgs e)
    {
      if (svcTimer.Interval == 1) svcTimer.Interval = 1000;

      SetControlStatus();
    }

    private void SetControlStatus()
    {
      serviceStatus = cont.GetServiceStatus();
      txtSvcStatus.Text = serviceStatus.ToString();

      btnStartSvc.Enabled = !isLoading && (serviceStatus == ServiceStatus.Stopped || serviceStatus == ServiceStatus.None);
      btnStopSvc.Enabled = !isLoading && serviceStatus == ServiceStatus.Running;
      btnDelSvc.Enabled = !isLoading && serviceStatus != ServiceStatus.None;
    }
  }

  public interface IMain : IViewBase<MainController>
  {
    void SetIsLoading(bool isLoading);
    void AddOutput(string message);
  }
}
