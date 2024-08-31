using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcLib.Args
{
  public class FindIntervalArgs
  {
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ProcessName { get; set; } = "";
    public int TermSeconds { get; set; } = 60 * 10;
  }
}
