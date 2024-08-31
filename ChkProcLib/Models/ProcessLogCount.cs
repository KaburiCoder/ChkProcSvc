using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcLib.Models
{
  public class ProcessLogCount
  {
    public string ProcessName { get; set; }
    public string Status { get; set; }
    public DateTime IntervalStart { get; set; }
    public int Count { get; set; }
  }
}
