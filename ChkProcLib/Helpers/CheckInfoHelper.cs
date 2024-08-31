using ChkProcLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChkProcLib.Helpers
{
  public class CheckInfoHelper
  {
    private const string FILE_NAME = "setting.json";
    private readonly string filePath;
    public CheckInfoHelper()
    {
      filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FILE_NAME);
    }

    public void Save(List<CheckInfo> checkInfos)
    {
      string json = JsonConvert.SerializeObject(checkInfos, Formatting.Indented);

      using (var sw = new StreamWriter(filePath, false, Encoding.UTF8))
      {
        sw.Write(json);
      }
    }

    private string GetJson()
    {
      if (!File.Exists(filePath))
      {
        return "";
      }
      using (var sr = new StreamReader(filePath))
      {
        return sr.ReadToEnd();
      }
    }

    public List<CheckInfo> GetCheckInfos()
    {
      string json = GetJson();

      if (string.IsNullOrEmpty(json)) return new List<CheckInfo>();

      var list =  JsonConvert.DeserializeObject<List<CheckInfo>>(json);
      foreach(var info in list)
      {
        info.FullPath = info.FullPath.Replace("/", "\\"); // 윈도우 경로로 변환
      }
      return list;
    }
  }
}
