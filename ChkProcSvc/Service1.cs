using ChkProcLib.Helpers;
using ChkProcLib.Services;
using ChkProcSvc.Constants;
using ChkProcSvc.Shared;
using System;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Timers;

namespace ChkProcSvc
{
  public partial class Service1 : ServiceBase
  {
    private ProcessLogService processLogService = new ProcessLogService();
    private readonly Logger logger = new Logger();
    private Timer timer;
    FunctionCallManager functionCallManager = new FunctionCallManager();

    public Service1()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      logger.ServiceLog(ServiceLogStatus.Start, "Service Started");

      timer = new Timer(5000) { AutoReset = true, Enabled = true }; // 5초
      timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
    }

    private Process[] GetDaemonProcesses()
    {
      return Process.GetProcessesByName(ProcessConst.DAEMON_PROC_NAME);
    }

    protected override void OnStop()
    {
      logger.ServiceLog(ServiceLogStatus.Stop, "Service Stopped");

      timer.Enabled = false;
      timer.Dispose();
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
      try
      {
        var processes = GetDaemonProcesses();
        if (!processes.Any())
        {

          // 데몬 실행 로그
          logger.ServiceLog(ServiceLogStatus.TryStartDaemon, "Daemon Try to Start");

          string taskName = "ChkProcTask";

          CmdHelper.StartSchtasks(taskName, ProcessConst.DAEMON_FULL_PATH);

          processes = GetDaemonProcesses();
          if (!processes.Any())
          {
            // 데몬 실행 실패 로그
            logger.ServiceLog(ServiceLogStatus.TryStartDaemonFailure, "Failed to start the daemon process");
          }
        }

        // 하루에 한번씩 1달 지난 데이터 삭제
        functionCallManager.RunOncePerDay(() =>
        {
          try
          {
            logger.ServiceLog(ServiceLogStatus.DeleteLogs, "Deletes logs older than one month");
            processLogService.DeleteOldLogs();
            logger.DeleteOldLogs();
          }
          catch (Exception ex)
          {
            logger.ServiceLog(ServiceLogStatus.DeleteLogsError, ex.ToString());
          }
        });
      }
      catch (Exception ex)
      {
        logger.ServiceLog(ServiceLogStatus.UnhandledError, ex.ToString());
      }
    }


    public void OnDebug()
    {
      OnStart(null);
      while (true) { }
    }

    //private readonly Logger logger = new Logger();
    //private readonly object lockObj = new object();
    //private readonly CheckInfoHelper infoHelper = new CheckInfoHelper();

    //public Service1()
    //{
    //  InitializeComponent();
    //}

    //protected override void OnStart(string[] args)
    //{
    //  logger.ServiceLog(ServiceLogStatus.Start, "Service Started");

    //  List<CheckInfo> checkInfos = infoHelper.GetCheckInfos();
    //  foreach (var info in checkInfos)
    //  {
    //    ThreadPool.QueueUserWorkItem(new Worker(info, lockObj).WorkingMethod);
    //  }
    //}

    //protected override void OnStop()
    //{
    //  logger.ServiceLog(ServiceLogStatus.Stop, "Service Stopped");
    //}
  }
}
