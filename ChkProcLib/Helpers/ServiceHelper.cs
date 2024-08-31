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
    public static ServiceStatus GetStatus()
    {
      try
      {
        var sc = new ServiceController(SVC_NAME);
        return (ServiceStatus)sc.Status;
      }
      catch
      {
        return ServiceStatus.None;
      }
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
