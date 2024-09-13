using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcSvc.Shared
{
  public class FunctionCallManager
  {
    private DateTime _lastRunDate;
    private readonly TimeSpan _interval = TimeSpan.FromDays(1);

    public FunctionCallManager()
    {
      // 초기 값으로 과거의 시간을 설정하여 첫 번째 실행을 유도
      _lastRunDate = DateTime.MinValue;
    }

    public void RunOncePerDay(Action function)
    {
      DateTime now = DateTime.Now;

      // 마지막 실행 시간이 24시간(1일) 이상 지났는지 확인
      if ((now - _lastRunDate) >= _interval)
      {
        // 마지막 실행 시간 업데이트
        _lastRunDate = now;

        // 함수 실행
        function();
      }
    }
  }
}
