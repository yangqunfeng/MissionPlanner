/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    internal class ButtonMonitor
    {
    }
}
*/

using System;
using System.Threading;
using System.Windows.Forms;

public class ButtonMonitor
{
    private bool monitoring;
    private Thread monitoringThread;
    private Button button;

    public ButtonMonitor(Button button)
    {
        this.button = button;
    }

    public void StartMonitoring()
    {
        monitoring = true;
        monitoringThread = new Thread(MonitorButton);
        monitoringThread.IsBackground = true;
        monitoringThread.Start();
    }

    public void StopMonitoring()
    {
        monitoring = false;
        monitoringThread?.Join();
    }

    private void MonitorButton()
    {
        while (monitoring)
        {
            if (button.InvokeRequired)
            {
                button.Invoke((MethodInvoker)delegate
                {
                    if (button.Text == "Connect" || button.Text == "连接")
                    {
                        button.PerformClick();
                    }
                });
            }
            else
            {
                if (button.Text == "Connect")
                {
                    button.PerformClick();
                }
            }

            Thread.Sleep(1000); // Check every 1 second
        }
    }
}