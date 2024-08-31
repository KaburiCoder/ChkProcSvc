using ChkProcLib.Helpers;
using System;
using System.IO;
using System.Threading;
using System.ServiceProcess;

namespace ChkProc.Feature.Main
{
  public delegate void CommandMessageDelegate(SvcOutput svcOutput, string message);
  public delegate void CommandStatusDelegate(bool isLoading);
  public enum SvcOutput
  {
    Data,
    Error,
    Success,
  }

  public class SvcService
  {

    public event CommandMessageDelegate OnCommandMessage;
    public event CommandStatusDelegate OnCommandStatus;
    private string FilePath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{ServiceHelper.SVC_NAME}.exe");

    private void NewThread(Action action)
    {
      OnCommandStatus.Invoke(true);
      ThreadPool.QueueUserWorkItem((_) =>
      {
        action();
      });
    }

    private void ExecuteCommand(string command)
    {
      CmdHelper.ExecuteCommand(command,
        onReceived: (m) => OnCommandMessage(SvcOutput.Data, m),
        onError: (m) => OnCommandMessage(SvcOutput.Error, m),
        onComplete: () => OnCommandStatus(false));
    }

    private void CreateServiceCommand()
    {
      var scStatus = ServiceHelper.GetStatus();
      if (scStatus == ServiceStatus.None)
      {
        OnCommandStatus.Invoke(true);
        string command = $"sc create {ServiceHelper.SVC_NAME} binPath=\"{FilePath}\" start=auto obj= \"LocalSystem\"";

        ExecuteCommand(command);
      }
    }

    private void StopCommand()
    {
      var scStatus = ServiceHelper.GetStatus();
      if (scStatus == ServiceStatus.Running)
      {
        ExecuteCommand($"net stop {ServiceHelper.SVC_NAME}");
      }
    }

    public void Start()
    {
      NewThread(() =>
      {
        if (!File.Exists(FilePath))
        {
          OnCommandMessage(SvcOutput.Error, "서비스 실행 파일이 존재하지 않습니다.");
          OnCommandStatus.Invoke(false);
          return;
        }

        CreateServiceCommand();

        var scStatus = ServiceHelper.GetStatus();
        if (scStatus == ServiceStatus.Stopped)
        {
          OnCommandStatus.Invoke(true);
          string command = $"net start {ServiceHelper.SVC_NAME}";
          ExecuteCommand(command);
        }

        OnCommandStatus.Invoke(false);
      });
    }

    public void Stop()
    {
      NewThread(StopCommand);
    }

    public void Delete()
    {
      NewThread(() =>
      {
        StopCommand();
        ExecuteCommand($"sc delete {ServiceHelper.SVC_NAME}");
      });

    }
  }
}
