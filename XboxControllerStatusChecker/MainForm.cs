using SharpDX.XInput;
using XboxControllerBatteryChecker;

namespace XboxControllerStatusChecker
{
    public partial class MainForm : Form
    {
        private readonly CheckBatteryBackgroundTask _checkBatteryBackgroundTask;

        public MainForm()
        {
            InitializeComponent();
            _checkBatteryBackgroundTask = new CheckBatteryBackgroundTask();
        }

        public void UpdateBatteryInformation(BatteryInformation batteryInformation)
        {
            notifyIcon1.Text = $"Battery level: {batteryInformation.BatteryLevel}";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _checkBatteryBackgroundTask.Stop();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
