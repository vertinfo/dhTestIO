using System.Device.Gpio;
using System.Device.I2c;


namespace dhTestIO
{
    internal class Relays
    {
        I2cDevice i2cDevice = I2cDevice.Create(new I2cConnectionSettings(1, 0x20));
        GpioController controller = new GpioController(PinNumberingScheme.Board);
        
        public Relays()
        {
            Console.WriteLine($"i2c = {i2cDevice.ConnectionSettings.DeviceAddress}");
            controller.OpenPin(0xff &= 0x1 << (int)Pins.USL, PinMode.Output);
            Console.WriteLine($"gpio numbering = {controller.NumberingScheme}");
            controller.OpenPin(0xff &= 0x1 << (int)Pins.DSL, PinMode.Output);
            controller.OpenPin(0xff &= 0x1 << (int)Pins.SP3, PinMode.Output);
            controller.OpenPin(0xff &= 0x1 << (int)Pins.DCL, PinMode.Output);
            Console.WriteLine($"gpio pin count = {controller.PinCount}");
            Console.WriteLine($"gpio numbering = {controller.NumberingScheme}");
        }

        public void ON_1()
        {
            Console.WriteLine("ON 1...");
            
            controller.Write(0xff &= 0x1 << (int)Pins.USL, PinValue.High);
        }

        public void ON_2()
        {
            Console.WriteLine("ON 2...");
            controller.Write(0x1 << (int)Pins.DSL, PinValue.High);
        }

        public void ON_3()
        {
            Console.WriteLine("ON 3...");
            controller.Write(0x1 << (int)Pins.SP3, PinValue.High);
        }

        public void ON_4()
        {
            Console.WriteLine("ON 4...");
            controller.Write(0x1 << (int)Pins.DCL, PinValue.High);
        }

        public void OFF_1()
        {
            Console.WriteLine("OFF 1...");
            controller.Write(0x1 << (int)Pins.USL, PinValue.Low);
        }

        public void OFF_2()
        {
            Console.WriteLine("ON 2...");
            controller.Write(0x1 << (int)Pins.DSL, PinValue.Low);
        }

        public void OFF_3()
        {
            Console.WriteLine("OFF 3...");
            controller.Write(0x1 << (int)Pins.SP3, PinValue.Low);

        }

        public void OFF_4()
        {
            Console.WriteLine("OFF 4...");
            controller.Write(0x1 << (int)Pins.DCL, PinValue.Low);

        }
    }
}
