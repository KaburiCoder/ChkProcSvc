using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProcSvc.Constants
{
  public class ProcessConst
  {
    public const string DAEMON_PROC_NAME = "ChkProcDaemon";
    public static readonly string DAEMON_FULL_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{DAEMON_PROC_NAME}.exe") ;
  }
}
