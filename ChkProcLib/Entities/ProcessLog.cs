using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcLib.Entities
{
  public class ProcessLog
  {
    public int Id { get; set; }  // Id 컬럼에 대응
    public DateTime CreatedAt { get; set; }  // CreatedAt 컬럼에 대응
    public string ProcessName { get; set; }  // ProcessName 컬럼에 대응
    public string Status { get; set; }  // Status 컬럼에 대응
    public string Message { get; set; }  // Message 컬럼에 대응
  }
}
