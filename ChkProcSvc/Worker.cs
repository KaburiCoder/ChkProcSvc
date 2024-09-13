using ChkProcLib.Helpers;
using ChkProcLib.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ChkProcSvc
{
  public class Worker
  {
    private readonly CheckInfo info;
    private readonly object lockObj;
    private readonly Logger logger = new Logger();
    private readonly string taskName;
    public Worker(CheckInfo info, object lockObj)
    {
      this.info = info;
      this.lockObj = lockObj;
      this.taskName = $"ChkProcTask_{Thread.CurrentThread.ManagedThreadId}";
    }

    public void WorkingMethod(object _)
    {
      int sleepMs = info.Sec * 1000;
      while (true)
      {
        var startTime = DateTime.Now;

        try
        {
          Working();
        }
        catch (Exception ex)
        {
          logger.DaemonLog(DaemonLogStatus.WorkingError, $"{ex}\n    path: {info.FullPath}");
        }

        // 작업에 소요된 시간 계산
        var elapsedMs = (int)(DateTime.Now - startTime).TotalMilliseconds;
        // 다음 실행까지 남은 시간을 계산
        int remainingSleepMs = Math.Max(sleepMs - elapsedMs, 1000);
        Thread.Sleep(remainingSleepMs);
      }
    }

    private Process GetRunningProcess(out string processName, out int pid)
    {
      var fileUtil = new FileHelper(info.FullPath);
      processName = fileUtil.GetProcessName();
      var process = Process.GetProcessesByName(processName).FirstOrDefault();
      pid = process?.Id ?? 0;
      return process;
    }

    //private bool RunProcess(out int pid, out string err)
    //{
    //  try
    //  {
    //    var process = ProcessHelper.RunAsAdmin(info.FullPath.Replace("\\", "/"));
    //    pid = (process?.Id ?? 0);
    //    err = null;
    //    return true;
    //  }
    //  catch (Exception ex)
    //  {
    //    err = $"\n{ex}";
    //    pid = 0;
    //    return false;
    //  }
    //}

    public void Working()
    {
      GetRunningProcess(out string processName, out int pid);
      LogStatus status = pid > 0 ? LogStatus.Active : LogStatus.Inactive;

      lock (lockObj) // 로그 저장 시 임계영역에서 저장
      {
        logger.Log(processName, status, $"Status: {status}", pid: pid);
        if (status == LogStatus.Inactive)
        {
          logger.Log(processName, status, $"[{info.FullPath}] Trying to Start");

          string err = "";
          try
          {
            CmdHelper.StartSchtasks(taskName, info.FullPath.Replace("\\", "/"));
            GetRunningProcess(out processName, out pid);
            
          }
          catch (Exception ex)
          {
            err = $"\n{ex}";
          }

          bool successStarted = pid > 0;
          string logMessage = $"[{info.FullPath}] " + (successStarted
            ? $"Successfully Started"
            : $"Failed to Start" + err);

          logger.Log(processName, successStarted ? LogStatus.Active : LogStatus.Inactive, logMessage, pid: (int)pid);
        }
      }
    }
  }
}
