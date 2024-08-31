using Dapper;
using System.Data.SQLite;

namespace ChkProcLib.Helpers
{
  public class SQLiteProvider
  {
    private static readonly SQLiteProvider instance = new SQLiteProvider();
    public static SQLiteProvider Instance => instance;
    public SQLiteConnection Conn => new SQLiteHelper().Conn;

    private SQLiteProvider()
    {
      using (Conn)
      {
        string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS ProcessLog (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                    ProcessName TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    Message TEXT
                );";
        Conn.Execute(createTableQuery, null);

        string createCompositeIndexQuery = @"
                    CREATE INDEX IF NOT EXISTS idx_createdat_processname
                    ON ProcessLog (CreatedAt, ProcessName);";
        Conn.Execute(createCompositeIndexQuery, null);
      }
    }
  }

}
