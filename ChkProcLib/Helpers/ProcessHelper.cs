using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;

namespace ChkProcLib.Helpers
{
  public class ProcessHelper
  {
    public static Process Run(string fileName, string arguments = "", bool isAdmin = false)
    {
      ProcessStartInfo startInfo = new ProcessStartInfo
      {
        FileName = fileName,
        Arguments = arguments,
        UseShellExecute = isAdmin,
        Verb = isAdmin ? "runas" : null // 관리자 권한으로 실행
      };

      Process process = new Process
      {
        StartInfo = startInfo
      };
      process.Start();
      process.WaitForInputIdle(20000);
      Debug.Print("ID : " + process.Id.ToString());
      return process;
    }
    public static Process RunAsAdmin(string fileName, string arguments = "")
    {
      ProcessStartInfo startInfo = new ProcessStartInfo
      {
        FileName = fileName,
        Arguments = arguments,
        UseShellExecute = true,
        Verb = "runas" // 관리자 권한으로 실행
      };

      Process process = new Process
      {
        StartInfo = startInfo
      };
      process.Start();

      int elapsedTime = 0;
      int waitInterval = 100; // 100ms 대기

      // 5초 동안 프로세스 ID를 기다림
      while (process.Id == 0 && !process.HasExited && elapsedTime < 5000)
      {
        Thread.Sleep(waitInterval);
        elapsedTime += waitInterval;
      }

      //process.WaitForInputIdle(20000);
      return process;
    }

    public static string GetUserName()
    {
      string query = "SELECT * FROM Win32_ComputerSystem";
      using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
      {
        foreach (ManagementObject mo in searcher.Get())
        {
          return mo["UserName"].ToString();
        }
      }
      return "";
    }
  }
}
