using ChkProcLib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChkProcDaemon.Shared
{
  public class ServiceUtil
  {
    public static void KillProcessIfNotService()
    {
#if !DEBUG      
      if (ServiceHelper.GetStatus() != ServiceStatus.Running)
      {
        Application.Exit();
      }
#endif
    }
  }
}
