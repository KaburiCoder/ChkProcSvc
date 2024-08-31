using ChkProcDaemon.Shared;
using ChkProcLib.Helpers;
using ChkProcLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChkProcDaemon
{
  public partial class Daemon : Form
  {
    private Logger logger = new Logger();
    private CheckInfoHelper infoHelper = new CheckInfoHelper();
    private readonly object lockObj = new object();
    public Daemon()
    {
      InitializeComponent();
      Shown += Form1_Shown;
      FormClosed += Daemon_FormClosed;
    }

    private void Daemon_FormClosed(object sender, FormClosedEventArgs e)
    {
      logger.DaemonLog(DaemonLogStatus.Stop, "Daemon Stopped");
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      Hide();
      OnStart();
    }

    private void OnStart()
    {
      logger.DaemonLog(DaemonLogStatus.Start, "Daemon Started");

      List<CheckInfo> checkInfos = infoHelper.GetCheckInfos();
      foreach (var info in checkInfos)
      {
        ThreadPool.QueueUserWorkItem(new Worker(info, lockObj).WorkingMethod);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      ServiceUtil.KillProcessIfNotService();
    }
  }
}
