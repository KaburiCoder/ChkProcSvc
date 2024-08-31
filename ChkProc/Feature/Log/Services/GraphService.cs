using DevComponents.DotNetBar.Charts;
using DevComponents.DotNetBar.Charts.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ChkProc.Feature.Log.Services
{
  public class GraphService
  {
    ChartControl chartControl;
    ChartXy chartXy;

    public ChartControl ChartControl => chartControl;
    public ChartXy ChartXy => chartXy;
    public ChartControl SetupChart()
    {
      chartControl = new ChartControl
      {
        Name = "chartControl"
      };

      SetupScrollBarStyles();
      AddChart();

      return chartControl;
    }

    private void SetupScrollBarStyles()
    {
      ScrollBarVisualStyle moStyle =
          chartControl.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver;

      moStyle.ArrowBackground = new Background(Color.AliceBlue);
      moStyle.ThumbBackground = new Background(Color.AliceBlue);

      ScrollBarVisualStyle smoStyle =
          chartControl.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver;

      smoStyle.ArrowBackground = new Background(Color.White);
      smoStyle.ThumbBackground = new Background(Color.White);

      moStyle = chartControl.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver;

      moStyle.ArrowBackground = new Background(Color.AliceBlue);
      moStyle.ThumbBackground = new Background(Color.AliceBlue);

      smoStyle = chartControl.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver;

      smoStyle.ArrowBackground = new Background(Color.White);
      smoStyle.ThumbBackground = new Background(Color.White);
    }

    private void AddChart()
    {
      chartXy = new ChartXy();
      chartXy.Name = "chartxy";
      chartXy.MinContentSize = new Size(300, 300);

      // Setup our Crosshair display.

      chartXy.ChartCrosshair.AxisOrientation = AxisOrientation.X;
      chartXy.ChartCrosshair.CrosshairLabelMode = CrosshairLabelMode.Common;
      chartXy.ChartCrosshair.ShowCrosshairLabels = true;

      chartXy.ChartCrosshair.ShowValueXLine = true;
      chartXy.ChartCrosshair.ShowValueYLine = true;
      chartXy.ChartCrosshair.ShowValueXLabels = true;
      chartXy.ChartCrosshair.ShowValueYLabels = true;

      // Set how we would like the line plot to be displayed.

      chartXy.ChartLineDisplayMode =
          ChartLineDisplayMode.DisplayPoints | ChartLineDisplayMode.DisplaySpline;

      // Setup various styles for the chart...

      SetupChartStyle();
      SetupContainerStyle();
      SetupChartAxes();
      SetupChartLegend();

      // Add a chart title and associated series.

      AddChartTitle();
      //AddSeries();

      // And finally, add the chart to the ChartContainers
      // collection of chart elements.

      chartControl.ChartPanel.ChartContainers.Add(chartXy);
    }

    private void SetupChartStyle()
    {
      ChartXyVisualStyle xystyle = chartXy.ChartVisualStyle;

      xystyle.Background = new Background(Color.AliceBlue);
      xystyle.BorderThickness = new Thickness(1);
      xystyle.BorderColor = new BorderColor(Color.Black);

      xystyle.Padding = new Padding(10);
      xystyle.DropShadow.Enabled = Tbool.True;
    }

    private void SetupContainerStyle()
    {
      ContainerVisualStyle dstyle = chartXy.ContainerVisualStyles.Default;

      dstyle.Background = new Background(Color.White);
      dstyle.BorderColor = new BorderColor(Color.DimGray);
      dstyle.BorderThickness = new Thickness(1);

      dstyle.DropShadow.Enabled = Tbool.True;
      dstyle.Padding = new Padding(6);
    }

    private void SetupChartLegend()
    {
      ChartLegend legend = chartXy.Legend;

      legend.Visible = true;
      legend.ShowCheckBoxes = true;
      legend.AlignVerticalItems = true;

      legend.Placement = Placement.Outside;
      legend.Alignment = Alignment.TopRight;
      legend.Direction = Direction.TopToBottom;

      legend.MaxHorizontalPct = 50;
      legend.ItemSortDirection = SortDirection.Ascending;
      legend.MinContentSize = new Size(160, 0);

      ChartLegendItemVisualStyle listyle = legend.ChartLegendItemVisualStyles.Default;

      listyle.AllowWrap = Tbool.True;

      ChartLegendVisualStyle lstyle = legend.ChartLegendVisualStyles.Default;

      lstyle.Background = new Background(Color.FromArgb(200, Color.White));

      lstyle.BorderThickness = new Thickness(1);
      lstyle.BorderColor = new BorderColor(Color.Crimson);

      lstyle.Margin = new Padding(20);
      lstyle.Padding = new Padding(10);
    }

    private void AddChartTitle()
    {
      ChartTitle title = new ChartTitle();

      title.Text = "프로세스 Inactive 상태 그래프";
      title.XyAlignment = XyAlignment.Top;

      ChartTitleVisualStyle tstyle = title.ChartTitleVisualStyle;

      tstyle.AllowWrap = Tbool.True;
      tstyle.Alignment = Alignment.MiddleCenter;

      tstyle.Padding = new Padding(4);
      tstyle.Font = new Font("Arial", 16, FontStyle.Italic);
      tstyle.Alignment = Alignment.MiddleCenter;

      chartXy.Titles.Add(title);
    }

    private void SetupChartAxes()
    {
      // X-Axis

      ChartAxis axis = chartXy.AxisX;

      axis.AxisMargins = 30;

      axis.MinorTickmarks.TickmarkCount = 1;
      axis.MajorTickmarks.StaggerLabels = true;

      axis.MajorTickmarks.Visible = false;
      axis.MinorTickmarks.Visible = false;
      axis.MajorGridLines.Visible = false;

      // Y-Axis

      axis = chartXy.AxisY;

      axis.AxisMargins = 30;
      axis.GridSpacing = 5;

      axis.MinorTickmarks.TickmarkCount = 5;

      axis.MajorTickmarks.ChartTickmarkVisualStyle.TickmarkAlignment = LineAlignment.Far;
      axis.MinorTickmarks.ChartTickmarkVisualStyle.TickmarkAlignment = LineAlignment.Far;

      axis.AxisAlignment = AxisAlignment.Far;
    }
  }
}
