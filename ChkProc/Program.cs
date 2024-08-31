using ChkProc.Feature.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChkProc
{
  static class Program
  {
    /// <summary>
    /// 해당 애플리케이션의 주 진입점입니다.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var view = new MainView();
      new MainController(view);
      Application.Run(view);
    }
  }
}
