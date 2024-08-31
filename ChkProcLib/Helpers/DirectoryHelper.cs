using ChkProcLib.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class DirectoryHelper
  {
    public static DirectoryInfo CreateDirectory(string path)
    {
      var di = new DirectoryInfo(path);
      if (!di.Exists) di.Create();

      return di;
    }

    public static void CreateLogsDirectory()
    {
      CreateDirectory(Paths.Logs);
    }
  }
}
