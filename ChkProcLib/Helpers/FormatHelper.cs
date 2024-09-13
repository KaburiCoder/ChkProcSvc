using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class FormatHelper
  {
    public static string FormatTime(int totalSeconds)
    {
      int hours = totalSeconds / 3600;  // 시
      int minutes = (totalSeconds % 3600) / 60;  // 분
      int seconds = totalSeconds % 60;  // 초

      List<string> times = new List<string>();
      if (hours > 0) times.Add($"{hours}시간");
      if (minutes > 0) times.Add($"{minutes}분");
      if (seconds > 0) times.Add($"{seconds}초");

      return string.Join(" ", times.ToArray());
    }
  }
}
