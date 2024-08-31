using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProc.Shared.Interfaces
{
  public interface IViewBase<T>
    where T : class
  {
    void Close();
    void SetController(T controller);
  }
}
