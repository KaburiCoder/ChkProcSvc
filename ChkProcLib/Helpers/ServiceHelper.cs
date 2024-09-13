using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class ServiceHelper
  {
    public const string SVC_NAME = "ChkProcSvc";
    public static ServiceStatus GetStatus(string serviceName = SVC_NAME)
    {
      try
      {
        var sc = new ServiceController(serviceName);
        return (ServiceStatus)sc.Status;
      }
      catch
      {
        return ServiceStatus.None;
      }
    }

    public static ServiceController[] GetServices()
    {
      ServiceController[] services = ServiceController.GetServices();
      return services;
    }
  }


  public enum ServiceStatus
  {
    None = 0,
    Stopped = 1,
    StartPending = 2,
    StopPending = 3,
    Running = 4,
    ContinuePending = 5,
    PausePending = 6,
    Paused = 7
  }
}
