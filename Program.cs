// See https://aka.ms/new-console-template for more information
using dhTestIO;

Console.WriteLine("Hello, World!");

// foreach(Pins pin in Enum.GetValues(typeof(Pins)))
// {
//     int i = 1;
//     Console.WriteLine($"Pin {i} = {pin}");
//     i++;
// }
Relays relays = new Relays();
while (true)
{
    relays.ON_1();
    Thread.Sleep(5000);
    relays.OFF_1();
    Thread.Sleep(5000);
    relays.ON_2();
    Thread.Sleep(5000);
    relays.OFF_2();
    Thread.Sleep(5000);
    relays.ON_3();
    Thread.Sleep(5000);
    relays.OFF_3();
    Thread.Sleep(5000);
    relays.ON_4();
    Thread.Sleep(5000);
    relays.OFF_4();
    Thread.Sleep(5000);
}