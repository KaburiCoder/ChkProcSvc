using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProcLib.Constants
{
  public class Paths
  {
    public readonly static string Logs = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
  }
}
