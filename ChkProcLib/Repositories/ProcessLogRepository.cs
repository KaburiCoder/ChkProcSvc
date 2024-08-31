using ChkProcLib.Args;
using ChkProcLib.Entities;
using ChkProcLib.Helpers;
using ChkProcLib.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChkProcLib.Repositories
{
  public class ProcessLogRepository
  {
    public IEnumerable<ProcessLog> FindAll()
    {
      using (var conn = SQLiteProvider.Instance.Conn)
      {
        return conn.Query<ProcessLog>("SELECT * FROM ProcessLog", null);
      }
    }

    public long Save(ProcessLog processLog)
    {
      using (var conn = SQLiteProvider.Instance.Conn)
      {
        string sql = $@"
INSERT INTO ProcessLog (CreatedAt, ProcessName, Status, Message)
                VALUES (@CreatedAt, @ProcessName, @Status, @Message);
SELECT last_insert_rowid();";

        var result = conn.Query<long>(sql, processLog);
        return result.FirstOrDefault();
      }
    }

    private string GetProcessNameQuery(string processName)
    {
      if (!string.IsNullOrEmpty(processName))
      {
        return " AND ProcessName IN (@processName, '<Service>', '<Daemon>')";
      }
      return "";
    }

    public List<ProcessLog> Find(DateTime startDate, DateTime endDate, string processName)
    {
      string query = @"
        SELECT * FROM ProcessLog
        WHERE CreatedAt >= @startDate AND CreatedAt <= @endDate" + GetProcessNameQuery(processName);

      using (var connection = SQLiteProvider.Instance.Conn)
      {
        return connection.Query<ProcessLog>(query, new { startDate, endDate, processName }).ToList();
      }
    }

    public List<ProcessLog> FindNew(int lastId, string processName)
    {
      string query = @"
        SELECT * FROM ProcessLog
        WHERE Id > @lastId " + GetProcessNameQuery(processName);

      using (var connection = SQLiteProvider.Instance.Conn)
      {
        return connection.Query<ProcessLog>(query, new { lastId, processName }).ToList();
      }
    }

    public List<ProcessLogCount> FindInactiveInterval(FindIntervalArgs args)
    {
      string query = $@"
SELECT 
	ProcessName, Status,
  datetime((strftime('%s', CreatedAt) / @TermSeconds) * @TermSeconds, 'unixepoch') AS IntervalStart,
  COUNT(*) AS Count
FROM 
    ProcessLog
WHERE status = 'Inactive'
AND CreatedAt >= @StartDate AND CreatedAt <= @EndDate ";
      if (!string.IsNullOrEmpty(args.ProcessName))
      {
        query += @"
AND ProcessName = @ProcessName";
      }
      query += @"
GROUP BY 
    IntervalStart, ProcessName, Status 
ORDER BY 
    IntervalStart;";
      using (var connection = SQLiteProvider.Instance.Conn)
      {
        return connection.Query<ProcessLogCount>(query, args).ToList();
      }
    }
  }
}
