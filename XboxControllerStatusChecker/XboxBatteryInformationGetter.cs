using SharpDX.XInput;

namespace XboxControllerStatusChecker
{
    internal class XboxBatteryInformationGetter
    {
        public static BatteryInformation GetBatteryInformation(int userIndex)
        {
            var controller = new Controller((UserIndex) userIndex);
            var batteryInformation = controller.GetBatteryInformation(BatteryDeviceType.Gamepad);
            return batteryInformation;
        }
    }
}
