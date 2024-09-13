using ChkProcLib.Args;
using ChkProcLib.Entities;
using ChkProcLib.Models;
using ChkProcLib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcLib.Services
{
  public class ProcessLogService
  {
    private ProcessLogRepository repo = new ProcessLogRepository();

    public long Save(ProcessLog processLog)
    {
      return repo.Save(processLog);
    }

    public List<ProcessLog> Find(DateTime startDate, DateTime endDate, string processName)
    {
      var range = new DateRangeBuilder(startDate, endDate);

      return repo.Find(range.StartDate, range.EndDate, processName);
    }

    public void DeleteOldLogs()
    {
      var now = DateTime.Now;
      var startDate = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddMonths(-1);

      repo.DeleteBefore(startDate);
    }

    public List<ProcessLog> FindNew(long lastId, string processName)
    {
      return repo.FindNew(lastId, processName);
    }

    public List<ProcessLogCount> FindInactiveInterval(FindIntervalArgs args)
    {
      var range = new DateRangeBuilder(args.StartDate, args.EndDate);
      args.StartDate = range.StartDate;
      args.EndDate = range.EndDate;
      return repo.FindInactiveInterval(args);
    }
  }

  public class DateRangeBuilder
  {
    readonly DateTime sDt;
    readonly DateTime eDt;
    public DateTime StartDate => sDt;
    public DateTime EndDate => eDt;
    public DateRangeBuilder(DateTime startDate, DateTime endDate)
    {
      sDt = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0);
      eDt = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);
    }
  }
}
