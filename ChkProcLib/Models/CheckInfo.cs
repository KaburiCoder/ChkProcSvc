using Newtonsoft.Json;
using System.IO;

namespace ChkProcLib.Models
{
  public class CheckInfo
  {
    public string FullPath { get; set; } = "";
    public int Sec { get; set; } = 10;

    [JsonIgnore]
    public string ProcessName => Path.GetFileNameWithoutExtension(FullPath);

    public CheckInfo DeepCopy()
    {
      var json = JsonConvert.SerializeObject(this);
      return JsonConvert.DeserializeObject<CheckInfo>(json);
    }
  }
}
