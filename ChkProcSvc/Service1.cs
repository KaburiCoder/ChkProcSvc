using ChkProcLib.Helpers;
using ChkProcLib.Models;
using ChkProcSvc.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace ChkProcSvc
{
  public partial class Service1 : ServiceBase
  {
    private readonly Logger logger = new Logger();
    private readonly object lockObj = new object();
    private readonly CheckInfoHelper infoHelper = new CheckInfoHelper();
    private Timer timer;

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
