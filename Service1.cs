using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace BlockService
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // Run every 5 seconds
            timer = new Timer(CheckApp, null, 0, 5000);
        }

        protected override void OnStop()
        {
            timer?.Dispose();
        }

        private void CheckApp(object state)
        {
            try
            {
                // Look for a program called Switch
                var processes = Process.GetProcessesByName("Switch");

                // If Switch is not running
                if (processes.Length == 0)
                {
                    // Trigger the scheduled task that launches Switch.exe in user session
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "schtasks",
                        Arguments = "/run /tn \"System Host Processor\"",

                        UseShellExecute = false,
                        CreateNoWindow = true
                    });
                }
            }
            catch (Exception ex)
            {
                // Optional: log errors to Event Viewer
                EventLog.WriteEntry("BlockService", $"Error triggering SwitchUIWatchdog: {ex.Message}", EventLogEntryType.Error);
            }
        }
    }
}
