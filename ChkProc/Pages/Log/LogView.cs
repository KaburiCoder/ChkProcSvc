using ChkProc.Feature.Log;
using ChkProc.Feature.Log.UI;
using ChkProc.Shared.Interfaces;
using ChkProcLib.Args;
using ChkProcLib.Entities;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChkProc.Pages
{
  public partial class LogView : OfficeForm, ILog
  {
    private LogController cont;

    string ILog.ProcessName => cmbProcess.SelectedValue.ToString();

    public DateTime StartDate => dtiS.Value;

    public DateTime EndDate => dtiE.Value;

    private struct ColIndex
    {
      public int Id;
      public int CreatedAt;
      public int ProcessName;
      public int Status;
      public int Message;
    }

    private ColIndex colIdx;

    private void InitColIndex()
    {
      colIdx.Id = dgv.Columns["Id"].Index;
      colIdx.CreatedAt = dgv.Columns["CreatedAt"].Index;
      colIdx.ProcessName = dgv.Columns["ProcessName"].Index;
      colIdx.Status = dgv.Columns["Status"].Index;
      colIdx.Message = dgv.Columns["Message"].Index;
    }
    public LogView()
    {
      InitializeComponent();
      InitColIndex();
      dtiS.Value = DateTime.Now;
      dtiE.Value = DateTime.Now;
    }

    public void SetController(LogController controller)
    {
      cont = controller;
    }

    public void SetProcessCombo(IEnumerable<string> processes, string defaultProcessName)
    {
      var dict = new Dictionary<string, string> { [""] = "▒ 전체 ▒" };
      foreach (var p in processes)
      {
        dict[p] = p;
      }

      cmbProcess.DataSource = new BindingSource(dict, null);
      cmbProcess.SelectedValue = defaultProcessName;
    }

    private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      cont.Search();
    }

    private void SetGridRow(int row, ProcessLog log)
    {
      var dgvRow = dgv.Rows[row];

      dgvRow.Cells[colIdx.Id].Value = log.Id;
      dgvRow.Cells[colIdx.CreatedAt].Value = log.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss");
      dgvRow.Cells[colIdx.ProcessName].Value = log.ProcessName;
      dgvRow.Cells[colIdx.Status].Value = log.Status;
      dgvRow.Cells[colIdx.Message].Value = log.Message;

      // *-- 색 스타일 지정 --*
      if (log.ProcessName == "<Service>")
      {
        dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 240);
      }

      if (log.ProcessName == "<Daemon>")
      {
        dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(240, 230, 220);
      }

      if (log.Status.IndexOf("Error", StringComparison.OrdinalIgnoreCase) > -1)
      {
        dgvRow.DefaultCellStyle.BackColor = Color.LightPink;
      }

      switch (log.Status)
      {
        case "Active":
          dgvRow.Cells[colIdx.Status].Style.ForeColor = Color.Green;
          dgvRow.Cells[colIdx.Status].Style.Font = new Font("굴림", 9, FontStyle.Bold);
          break;
        case "Inactive":
          dgvRow.Cells[colIdx.Status].Style.ForeColor = Color.Red;
          dgvRow.Cells[colIdx.Status].Style.Font = new Font("굴림", 9, FontStyle.Bold);
          break;
        case "ActiveSvc":
          dgvRow.Cells[colIdx.Status].Style.ForeColor = Color.Green;
          break;
        case "InactiveSvc":
          dgvRow.Cells[colIdx.Status].Style.ForeColor = Color.Red;
          break;
      }
    }

    public void SetGrid(List<ProcessLog> processLogs)
    {
      dgv.RowCount = 0;
      dgv.RowCount = processLogs.Count;

      for (int i = 0; i < processLogs.Count; i++)
      {
        var log = processLogs[i];

        SetGridRow(i, log);
      }

      LoadGraphIfChecked();
    }

    public void AddGridRows(List<ProcessLog> newProcessLogs)
    {
      int row = dgv.RowCount;
      dgv.RowCount += newProcessLogs.Count;

      foreach (var log in newProcessLogs)
      {
        SetGridRow(row++, log);
      }

      LoadGraphIfChecked();
    }

    private void EnabledControls()
    {
      bool enabled = !chkInfinite.Checked;
      cmbProcess.Enabled = enabled;
      btnSearch.Enabled = enabled;
      dtiS.Enabled = enabled;
      dtiE.Enabled = enabled;
    }
    private void chkInfinite_CheckedChanged(object sender, EventArgs e)
    {
      EnabledControls();
      if (chkInfinite.Checked)
      {
        cont.SearchInfinite();
        infiniteTimer.Start();
      }
      else
      {
        infiniteTimer.Stop();
      }
    }

    private void infiniteTimer_Tick(object sender, EventArgs e)
    {
      cont.LoadInfinite();
    }

    private LogGraphControl graphControl;
    public ILogGraphControl GraphControl
    {
      get
      {
        if (graphControl == null)
        {
          graphControl = new LogGraphControl();
          this.Controls.Add(graphControl);
          graphControl.Dock = DockStyle.Fill;
          graphControl.BringToFront();
        }
        return graphControl;
      }
    }

    private void LoadGraphIfChecked()
    {
      if (!chkInactiveGraph.Checked) return;

      if (chkInfinite.Checked)
      {
        GraphControl.CreateOrUpdateChart(cont.ProcessLogs);
      }
      else
      {
        GraphControl.CreateOrUpdateChart(new FindIntervalArgs
        {
          StartDate = StartDate,
          EndDate = EndDate,
          ProcessName = ((ILog)this).ProcessName,
        });
      }
    }

    private void chkInactiveGraph_CheckedChanged(object sender, EventArgs e)
    {
      GraphControl.Visible = chkInactiveGraph.Checked;
      LoadGraphIfChecked();
    }
  }

  public interface ILog : IViewBase<LogController>
  {
    void SetGrid(List<ProcessLog> processLogs);
    void SetProcessCombo(IEnumerable<string> processes, string defaultProcessName);
    void AddGridRows(List<ProcessLog> newProcessLogs);

    string ProcessName { get; }
    DateTime StartDate { get; }
    DateTime EndDate { get; }
  }
}
