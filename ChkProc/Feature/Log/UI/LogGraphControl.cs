using ChkProc.Feature.Log.Services;
using ChkProcLib.Args;
using ChkProcLib.Entities;
using ChkProcLib.Models;
using ChkProcLib.Services;
using DevComponents.DotNetBar.Charts;
using DevComponents.DotNetBar.Charts.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChkProc.Feature.Log.UI
{
  public partial class LogGraphControl : UserControl, ILogGraphControl
  {
    private ProcessLogService processLogService = new ProcessLogService();
    private readonly GraphService graphService = new GraphService();
    List<ProcessLog> processLogs;

    public int MinTerm => iiMin.Value;

    #region SetupChart
    private void SetupChart()
    {
      var chartControl = graphService.SetupChart();
      this.Controls.Add(chartControl);
      chartControl.Name = "chartControl";
      chartControl.Location = new Point(10, 10);
      chartControl.Size = new Size(ClientRectangle.Width - 20, 491);
      chartControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
      chartControl.Dock = DockStyle.Fill;
      chartControl.BringToFront();     
    }
    #endregion

    #region Private Methods
    private void CreateOrUpdateChart(List<ProcessLogCount> logs)
    {
      if (graphService.ChartControl == null)
      {
        SetupChart();
        flpnlMinTerm.BringToFront();
      }
      AddSeries(logs);
    }

    private void AddSeries(List<ProcessLogCount> logs)
    {
      graphService.ChartXy.ChartSeries.Clear();

      var processNames = logs.GroupBy(log => log.ProcessName).Select(gr => gr.Key);
      var dateTimes = logs.GroupBy(log => log.IntervalStart).Select(gr => gr.Key);

      var processDict = new Dictionary<string, Dictionary<DateTime, ProcessLogCount>>();

      foreach (var processName in processNames)
      {
        var dict = new Dictionary<DateTime, List<ProcessLogCount>>();

        processDict[processName] = dateTimes.ToDictionary(dt => dt, dt => logs.Find(log => log.IntervalStart == dt && log.ProcessName == processName));
      }

      foreach (var processName in processDict.Keys)
      {
        AddSeries(graphService.ChartXy, processName, dateTimes, processDict[processName]);
      }
    }

    private void AddSeries(ChartXy chartXy, string processName, IEnumerable<DateTime> dateTimes, Dictionary<DateTime, ProcessLogCount> dtLogDict)
    {
      ChartSeries series = new ChartSeries(processName, SeriesType.Line);

      series.StackQualitativePoints = false;


      //if (index % 3 == 0)
      //{
      series.ShowCheckBoxInLegend = false;
      series.ChartSeriesVisualStyle.LineStyle.LinePattern = LinePattern.Dash;
      //}

      // Create and add our SeriesPoints.

      foreach (var dateTime in dateTimes)
      {
        if (dtLogDict.TryGetValue(dateTime, out ProcessLogCount log))
          series.SeriesPoints.Add(new SeriesPoint(dateTime.ToString("MM/dd\nHH:mm"), log?.Count));
      }

      ChartSeriesVisualStyle sstyle = series.ChartSeriesVisualStyle;
      PointMarkerVisualStyle pstyle = sstyle.MarkerVisualStyle;

      pstyle.Type = PointMarkerType.Diamond;
      pstyle.Size = new Size(7, 7);
      pstyle.BorderColor = Color.Black;
      pstyle.Background = new Background(series.DefaultPaletteColor);

      // Add the series to the chart.

      chartXy.ChartSeries.Add(series);
    }
    #endregion


    public LogGraphControl()
    {
      InitializeComponent();

    }

    public void CreateOrUpdateChart(FindIntervalArgs args)
    {
      var logs = processLogService.Find(args.StartDate, args.EndDate, args.ProcessName);
      //args.TermSeconds = 60 * MinTerm;
      //var result = processLogService.FindInactiveInterval(args);
      CreateOrUpdateChart(logs);
    }

    public void CreateOrUpdateChart(List<ProcessLog> logs)
    {
      processLogs = logs;

      var groupedLogs = logs
          .Where(log => log.Status == "Inactive")
          .GroupBy(log => new
          {
            ProcessName = log.ProcessName,
            IntervalStart = new DateTime(log.CreatedAt.Year, log.CreatedAt.Month, log.CreatedAt.Day, log.CreatedAt.Hour, log.CreatedAt.Minute / MinTerm * MinTerm, 0)
          })
          .Select(g => new ProcessLogCount
          {
            ProcessName = g.Key.ProcessName,
            IntervalStart = g.Key.IntervalStart,
            Count = g.Count()
          })
          .ToList();

      // 기존의 차트를 생성 또는 업데이트하는 메서드 호출
      CreateOrUpdateChart(groupedLogs);
    }

    private void iiMin_ValueChanged(object sender, EventArgs e)
    {
      if (processLogs == null) return;
      CreateOrUpdateChart(processLogs);
    }
  }

  public interface ILogGraphControl
  {
    bool Visible { get; set; }

    void CreateOrUpdateChart(FindIntervalArgs args);
    void CreateOrUpdateChart(List<ProcessLog> logs);
  }
}
