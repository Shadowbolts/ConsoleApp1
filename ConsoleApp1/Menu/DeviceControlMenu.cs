using ConsoleApp1.Devices;

namespace ConsoleApp1
{
    public static class DeviceControlMenu
    {
        public static void Control(Device device)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Змінити заряд батареї");
                Console.WriteLine("2 - Змінити стан програмного забезпечення");
                Console.WriteLine("3 - Змінити стан мережі");
                Console.WriteLine("4 - Змінити стан принтера");
                Console.WriteLine("5 - Змінити стан колонок");
                Console.WriteLine("9 - Вихід");

                if (Enum.TryParse(Console.ReadLine(), out ControlDeviceOption choice))
                {
                    switch (choice)
                    {
                        case ControlDeviceOption.ChangeBattery:
                            {
                                DeviceController.ChangeBattery(device);
                                break;
                            }
                        case ControlDeviceOption.ChangeSoftware:
                            {
                                DeviceController.ChangeSettings(device, "Програмне забезпечення");
                                break;
                            }
                        case ControlDeviceOption.ChangeNetwork:
                            {
                                DeviceController.ChangeSettings(device, "Мережу");
                                break;
                            }
                        case ControlDeviceOption.ChangePrinter:
                            {
                                DeviceController.ChangeSettings(device, "Принтер");
                                break;
                            }
                        case ControlDeviceOption.ChangeSpeaker:
                            {
                                DeviceController.ChangeSettings(device, "Колонки");
                                break;
                            }
                        case ControlDeviceOption.Exit:
                            {
                                DeviceMenu.Menu(device);
                                break;
                            }
                    }
                }
            }
        }
    }
}
