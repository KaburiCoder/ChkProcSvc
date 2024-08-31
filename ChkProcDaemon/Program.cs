using ChkProcLib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChkProcDaemon
{
  static class Program
  {
    /// <summary>
    /// 해당 애플리케이션의 주 진입점입니다.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.ThreadException += Application_ThreadException;
      AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
      {
        Exception ex = (Exception)args.ExceptionObject;
        var logger = new Logger();
        logger.DaemonLog(DaemonLogStatus.UnhandledError, ex.ToString());
      };

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Daemon());
    }

    private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
      var logger = new Logger();
      logger.DaemonLog(DaemonLogStatus.ThreadError, e.Exception.ToString());
    }
  }
}
