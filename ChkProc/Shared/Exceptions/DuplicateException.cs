using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProc.Shared.Exceptions
{
  public class DuplicateException : Exception
  {
    public DuplicateException(string message) : base(message)
    { }
  }
}
