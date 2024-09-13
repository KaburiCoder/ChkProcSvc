using ChkProc.Feature.Log;
using ChkProc.Pages;

namespace ChkProc.Shared.Router
{
  public class Router
  {
    public static LogView ShowLogView(string defaultProcessName)
    {
      var view = new LogView();
      new LogController(view, defaultProcessName);

      view.Show();
      return view;
    }
  }
}
