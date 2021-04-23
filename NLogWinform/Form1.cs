using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLogWinform
{
    public partial class Form1 : Form
    {
        private readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
            Logger.Info("Start Application");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Error, "Log Error");
        }

        private void BtnLogLevelTrace_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Trace, "Log Trace");
        }

        private void BtnLogLevelDebug_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Debug, "Log Debug");
        }

        private void BtnLogLevelInfo_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Info, "Log Info");
        }

        private void BtnLogLevelWarn_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Warn, "Log Warn");
        }

        private void BtnLogLevelError_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Error, "Log Error");
        }

        private void BtnLogLevelFatal_Click(object sender, EventArgs e)
        {
            Logger.Log(LogLevel.Fatal, "Log Fatal");
        }
    }
}
