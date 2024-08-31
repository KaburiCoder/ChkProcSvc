using ChkProc.Pages;
using ChkProcLib.Entities;
using ChkProcLib.Helpers;
using ChkProcLib.Models;
using ChkProcLib.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProc.Feature.Log
{
  public class LogController
  {
    private ILog view;
    private ProcessLogService processLogService = new ProcessLogService();
    private List<ProcessLog> processLogs = new List<ProcessLog>();

    public List<ProcessLog> ProcessLogs => processLogs;

    public LogController(ILog view, string defaultProcessName)
    {
      this.view = view;
      view.SetController(this);
      view.SetProcessCombo(GetProcessNames(), defaultProcessName);
      Search();
    }

    public IEnumerable<string> GetProcessNames()
    {
      return new CheckInfoHelper().GetCheckInfos()
        .Select(info => Path.GetFileNameWithoutExtension(info.FullPath));
    }

    internal void Search()
    {
      processLogs = processLogService.Find(view.StartDate, view.EndDate, view.ProcessName);
      view.SetGrid(processLogs);
    }

    internal void SearchInfinite()
    {
      processLogs = processLogService.Find(DateTime.Now, DateTime.Now, view.ProcessName);
      view.SetGrid(processLogs);
    }

    internal void LoadInfinite()
    {
      int lastId = processLogs.Count == 0 ? 0 : processLogs.Max(p => p.Id);
      var newProcessLogs = processLogService.FindNew(lastId, view.ProcessName);
      processLogs.AddRange(newProcessLogs);
      view.AddGridRows(newProcessLogs);
    }
  }
}
