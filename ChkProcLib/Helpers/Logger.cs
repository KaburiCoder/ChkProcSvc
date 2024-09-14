using ChkProcLib.Constants;
using ChkProcLib.Entities;
using ChkProcLib.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class Logger
  {
    private readonly ProcessLogService logService = new ProcessLogService();

    public Logger()
    {
      DirectoryHelper.CreateLogsDirectory();
    }

    private string CreateAndGetDir(string processName = "")
    {
      string dirPath = processName == "" ? Paths.Logs : Path.Combine(Paths.Logs, processName);

      return DirectoryHelper.CreateDirectory(dirPath).FullName;
    }

    private string GetFileFullName(string processName)
    {
      string dirPath = CreateAndGetDir(processName);
      string fileName = $"{DateTime.Now:yyyy-MM-dd}.log";
      return Path.Combine(dirPath, fileName);
    }

    private DateTime WriteLine(string path, string message)
    {
      DateTime now = DateTime.Now;
      try
      {
        using (var sw = new StreamWriter(path, append: true, Encoding.UTF8))
        {
          sw.WriteLine($"[{now:yyyy-MM-dd HH:mm:ss}] {message}");
        }

      }
      catch { }

      return now;
    }

    private string CreatePIDMark(int pid)
    {
      return pid > 0 ? $"[PID: {pid}] " : "";
    }

    public void Log(string processName, LogStatus status, string message, int pid = 0)
    {
      string fileFullName = GetFileFullName(processName);
      WriteLog(processName, fileFullName, CreatePIDMark(pid) + message, status.ToString());
    }

    private void WriteLog(string processName, string fileFullName, string message, string status, bool noSaveSQLite = false)
    {
      DateTime createdAt = WriteLine(fileFullName, message);
      if (noSaveSQLite) return;
      try
      {
        logService.Save(new ProcessLog
        {
          CreatedAt = createdAt,
          Message = message,
          Status = status,
          ProcessName = processName,
        });
      }
      catch (Exception ex)
      {
        ServiceLog(ServiceLogStatus.SQLiteError, ex.ToString(), noSaveSQLite: true);
      }
    }

    public void DeleteOldLogs()
    {
      // 현재 날짜에서 한 달 전 날짜 구하기
      DateTime oneMonthAgo = DateTime.Now.AddMonths(-1);

      // logDirectory 안의 모든 .log 파일 가져오기
      var logFiles = Directory.GetFiles(Paths.Logs, "*.log", SearchOption.AllDirectories);

      foreach (var logFile in logFiles)
      {
        // 파일명에서 날짜 추출 (파일명은 YYYY-MM-DD.log 형식으로 되어있다고 가정)
        string fileName = Path.GetFileNameWithoutExtension(logFile);

        if (DateTime.TryParse(fileName, out DateTime logDate))
        {
          // 로그 날짜가 한 달 이전이면 파일 삭제
          if (logDate < oneMonthAgo)
          {
            try
            {
              File.Delete(logFile);
            }
            catch { }
          }
        }
      }
    }

    public void ServiceLog(ServiceLogStatus status, string message, bool noSaveSQLite = false)
    {
      string pidMark = CreatePIDMark(Process.GetCurrentProcess().Id);
      string fileFullName = Path.Combine(Paths.Logs, "service.log");
      string logMessage = $"{pidMark}[{status}] {message}";

      WriteLog("<Service>", fileFullName, logMessage, status.ToString(), noSaveSQLite: noSaveSQLite);
    }

    public void DaemonLog(DaemonLogStatus status, string message)
    {
      string pidMark = CreatePIDMark(Process.GetCurrentProcess().Id);
      string fileFullName = Path.Combine(Paths.Logs, "daemon.log");
      string logMessage = $"{pidMark}[{status}] {message}";

      WriteLog("<Daemon>", fileFullName, logMessage, status.ToString());
    }
  }

  public enum LogStatus
  {
    Active,
    Inactive,
    ActiveSvc,
    InactiveSvc,
  }

  public enum ServiceLogStatus
  {
    Start,
    Stop,
    TryStartDaemon,
    TryStartDaemonFailure,
    WorkingError,
    UnhandledError,
    SQLiteError,
    DeleteLogs,
    DeleteLogsError,
  }

  public enum DaemonLogStatus
  {
    Start,
    Stop,
    WorkingError,
    UnhandledError,
    ThreadError,
  }
}
