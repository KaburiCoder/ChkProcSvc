using ChkProc.Shared.Exceptions;
using ChkProcLib.Helpers;
using ChkProcLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProc.Feature.Main
{
  public class MainController
  {
    private readonly IMain view;
    private SvcService svcService;
    private CheckInfoHelper infoHelper = new CheckInfoHelper();

    public MainController(IMain view)
    {
      this.view = view;
      view.SetController(this);

      svcService = new SvcService();
      svcService.OnCommandMessage += SvcService_OnCommandMessage;
      svcService.OnCommandStatus += SvcService_OnCommandStatus;
    }

    private void SvcService_OnCommandStatus(bool isLoading)
    {
      view.SetIsLoading(isLoading);
    }

    private void SvcService_OnCommandMessage(SvcOutput svcOutput, string message)
    {
      view.AddOutput($"{svcOutput}: {message}");
    }

    internal List<CheckInfo> GetCheckInfos()
    {
      return infoHelper.GetCheckInfos();
    }

    internal void DeleteService()
    {
      svcService.Delete();
    }

    internal void StopService()
    {
      svcService.Stop();
    }

    internal void StartService()
    {
      svcService.Start();
    }

    internal void SaveSettings(List<CheckInfo> values)
    {
      ValidateSettings(values);
      infoHelper.Save(values);
    }

    private void ValidateSettings(List<CheckInfo> values)
    {
      for (int i = 0; i < values.Count; i++)
      {
        for (int k = i + 1; k < values.Count; k++)
        {
          if (values.ElementAt(i).FullPath.ToLower() == values.ElementAt(k).FullPath.ToLower())
          {
            throw new DuplicateException("중복된 경로가 존재합니다.");
          }
        }
      }

      //for (int i = 0; i < values.Count; i++)
      //{
      //  var info = values[i];
      //  if (!File.Exists(info.FullPath))
      //  {
      //    throw new Exception($"[{info.FullPath}] 경로에 파일이 존재하지 않습니다.");
      //  }
      //}
    }

    internal ServiceStatus GetServiceStatus()
    {
      return ServiceHelper.GetStatus();
    }
  }
}
