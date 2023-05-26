using XboxControllerStatusChecker;
using Timer = System.Threading.Timer;

namespace XboxControllerBatteryChecker;

public class CheckBatteryBackgroundTask
{
    private readonly Timer _timer;

    public CheckBatteryBackgroundTask()
    {
        _timer = new Timer(CheckBattery, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
    }

    private static void CheckBattery(object state)
    {
        Program.MainForm.UpdateBatteryInformation(XboxBatteryInformationGetter.GetBatteryInformation(0));
    }

    public void Stop()
    {
        _timer.Dispose();
    }
}