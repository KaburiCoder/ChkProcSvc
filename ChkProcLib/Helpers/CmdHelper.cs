using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class CmdHelper
  {
    public static void ExecuteCommandAsAdministrator(
       string command,
       Action<string> onReceived,
       Action<string> onError,
       Action onComplete)
    {
      try
      {
        // ProcessStartInfo 설정
        ProcessStartInfo processInfo = new ProcessStartInfo()
        {
          FileName = "powershell.exe",     // PowerShell 실행
          Arguments = $"-Command \"{command}\"", // 실행할 명령어
          Verb = "runas",                  // 관리자 권한으로 실행
          UseShellExecute = true,         // 표준 입출력 리디렉션을 위해 false로 설정
          RedirectStandardOutput = true,   // 표준 출력을 리디렉션
          RedirectStandardError = true,    // 표준 오류를 리디렉션
          CreateNoWindow = true            // 창을 생성하지 않음
        };

        using (Process process = new Process())
        {
          process.StartInfo = processInfo;

          // 출력과 오류를 비동기적으로 처리
          process.OutputDataReceived += (sender, e) =>
          {
            if (!string.IsNullOrEmpty(e.Data))
            {
              onReceived?.Invoke(e.Data);
            }
          };

          process.ErrorDataReceived += (sender, e) =>
          {
            if (!string.IsNullOrEmpty(e.Data))
            {
              onError?.Invoke(e.Data);
            }
          };

          // 프로세스 시작
          process.Start();

          // 비동기적으로 출력 및 오류를 읽기 시작
          process.BeginOutputReadLine();
          process.BeginErrorReadLine();

          // 프로세스 종료까지 대기
          process.WaitForExit();
        }
      }
      catch (Exception ex)
      {
        onError?.Invoke($"Failed to execute command as administrator: {ex.Message}");
      }
      finally
      {
        onComplete?.Invoke();
      }
    }

    public static void ExecuteCommand(
      string command,
      Action<string> onReceived,
      Action<string> onError,
      Action onComplete)
    {
      try
      {
        // ProcessStartInfo 설정
        ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
        {
          UseShellExecute = false,   // ShellExecute를 true로 설정해야 Verb가 작동함
          Verb = "runas",           // 관리자 권한으로 실행하기 위해 'runas'를 설정
          CreateNoWindow = true,    // 창을 표시하지 않음
          RedirectStandardOutput = true,
          RedirectStandardError = true,
          WindowStyle = ProcessWindowStyle.Hidden // 창 숨기기
        };

        Process process = new Process();
        process.StartInfo = processInfo;

        process.OutputDataReceived += (sender, e) =>
        {
          if (!string.IsNullOrEmpty(e.Data)) onReceived?.Invoke(e.Data);
        };
        process.ErrorDataReceived += (sender, e) =>
        {
          if (!string.IsNullOrEmpty(e.Data)) onError?.Invoke(e.Data);
        };

        // 프로세스 시작
        process.Start();

        process.BeginOutputReadLine();
        process.BeginErrorReadLine();

        process.WaitForExit();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Failed to execute command as administrator: " + ex.Message);
      }
      finally
      {
        onComplete?.Invoke();
      }
    }

    public static void StartSchtasks(string taskName, string path, string args = "")
    {
      string userName = $"\"{ProcessHelper.GetUserName()}\"";
      taskName = $"\"{taskName}\"";
      path = $"\"\\\"{path}\"\\\"";

      string createCommand = $"schtasks /create /tn {taskName} /tr {path} {args} /sc once /st 00:00 /f /ru {userName}";
      string runCommand = $"schtasks /run /tn \"{taskName}\"";
      //string deleteCommand = $"schtasks /delete /tn \"{taskName}\" /f";

      Execute($"{createCommand} && {runCommand}"); // && {deleteCommand}
    }

    public static void DeleteSchtasks(string taskName)
    {
      ExecuteSchtasksCommand($"/delete /tn \"{taskName}\" /f");
    }

    public static void RunSchtasks(string taskName)
    {
      ExecuteSchtasksCommand($"/run /tn \"{taskName}\"");
    }

    public static void CreateSchtasks(string taskName, string path, string args = "")
    {
      string userName = $"\"{ProcessHelper.GetUserName()}\"";
      taskName = $"\"{taskName}\"";
      path = $"\"\\\"{path}\"\\\"";

      ExecuteSchtasksCommand($"/create /tn {taskName} /tr {path} {args} /sc once /st 00:00 /f /ru {userName}");
    }

    public static void ExecuteSchtasksCommand(string command)
    {
      // schtasks 명령을 실행할 때 필요한 전체 명령어를 결합합니다.
      string schtasksCommand = $"{command}";

      ProcessStartInfo startInfo = new ProcessStartInfo
      {
        FileName = "schtasks",
        Arguments = schtasksCommand,
        Verb = "runas",
        UseShellExecute = false,
        CreateNoWindow = true
      };

      try
      {
        Process process = Process.Start(startInfo);
        process.WaitForExit();
      }
      catch (System.ComponentModel.Win32Exception ex)
      {
        // 사용자가 UAC 프롬프트를 취소한 경우 등
        Console.WriteLine("The process was not started: " + ex.Message);
      }
    }

    public static void Execute(string command)
    {
      ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
      {
        Verb = "runas",
        UseShellExecute = false,
        CreateNoWindow = true
      };

      try
      {
        Process process = Process.Start(processInfo);
        process.WaitForExit();
      }
      catch (System.ComponentModel.Win32Exception ex)
      {
        // 사용자가 UAC 프롬프트를 취소한 경우 등
        Console.WriteLine("The process was not started: " + ex.Message);
      }
    }
  }
}
