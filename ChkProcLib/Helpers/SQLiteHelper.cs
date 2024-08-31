using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using ChkProcLib.Constants;
using Dapper;

namespace ChkProcLib.Helpers
{

  public class SQLiteHelper : IDisposable
  {
    public SQLiteConnection Conn;

    public SQLiteHelper()
    {
      DirectoryHelper.CreateLogsDirectory();
      string connectionString = $"Data Source={Path.Combine(Paths.Logs, "logs.sqlite")};Version=3;";

      Conn = new SQLiteConnection(connectionString);
      Conn.Open();
    }

    public void Dispose()
    {
      Conn?.Close();
      Conn = null;
    }
  }
}
