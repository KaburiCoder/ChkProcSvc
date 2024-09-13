using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ChkProcLib.Models
{
  public class CheckInfo
  {
    public string FullPath { get; set; } = "";
    public int Sec { get; set; } = 10;
    public List<RequiredService> RequiredServices { get; set; } = new List<RequiredService>();

    [JsonIgnore]
    public string ProcessName => Path.GetFileNameWithoutExtension(FullPath);

    public CheckInfo DeepCopy()
    {
      var json = JsonConvert.SerializeObject(this);
      return JsonConvert.DeserializeObject<CheckInfo>(json);
    }
  }

  public class RequiredService
  {
    public string DisplayName { get; set; }
    public string ServiceName { get; set; }
  }
}
