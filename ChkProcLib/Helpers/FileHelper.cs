using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class FileHelper
  {
    private readonly string fullPath;

    public FileHelper(string fullPath)
    {
      this.fullPath = fullPath;
    }

    public IEnumerable<Process> GetProcesses()
    {
      string query = $"SELECT * FROM Win32_Process WHERE ExecutablePath = '{fullPath.Replace("\\", "\\\\")}'";
      //string query = $"SELECT * FROM Win32_Process WHERE ProcessId = '7964'";
      using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", query))
      {
        foreach (ManagementObject obj in searcher.Get())
        {
          var pid = obj["ProcessId"] as uint?;
          Process process = Process.GetProcessById((int)pid);
          Console.WriteLine($"Process Name: {obj["Name"]}");
          Console.WriteLine($"Process ID: {obj["ProcessId"]}");
          Console.WriteLine($"Executable Path: {obj["ExecutablePath"]}");
          Console.WriteLine($"Command Line: {obj["CommandLine"]}");
          yield return process;
        }
      }
    }

    public string GetProcessName()
    {
      return Path.GetFileNameWithoutExtension(fullPath);
    }
  }
}
