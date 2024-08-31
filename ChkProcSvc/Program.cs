using ChkProcLib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace ChkProcSvc
{
  static class Program
  {
    /// <summary>
    /// 해당 애플리케이션의 주 진입점입니다.
    /// </summary>
    static void Main()
    {
      AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
      {
        Exception ex = (Exception)args.ExceptionObject;
        var logger = new Logger();
        logger.ServiceLog(ServiceLogStatus.UnhandledError, ex.ToString());
      };

#if DEBUG
      var service1 = new Service1();
      service1.OnDebug();
#else
      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[]
      {
                new Service1()
      };
      ServiceBase.Run(ServicesToRun);
#endif
    }
  }
}
