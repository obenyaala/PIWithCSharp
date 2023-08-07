// Change these values to match your servo motor specifications
using System.Device.Gpio;
using System.Device.I2c;
using System.Device.Pwm;
using System.Device.Pwm.Drivers;
using Iot.Device.MotorHat;
using Iot.Device.ServoMotor;

var gpioController = new GpioController(PinNumberingScheme.Board);
var pwmChanel = new SoftwarePwmChannel(12, 50, controller: gpioController);
int pulseWidthMinimum = 500; // Minimum pulse width (in microseconds)
int pulseWidthMaximum = 2500; // Maximum pulse width (in microseconds)
var servo = new ServoMotor(pwmChanel); 

System.Console.WriteLine("Start . . .");

Thread.Sleep(3000);

servo.Start();  // Enable control signal.

//await Task.Delay(TimeSpan.FromSeconds(5));
//Thread.Sleep(2000);

//servo.WriteAngle(0); // ~0.9ms; Approximately 0 degrees.
//await Task.Delay(TimeSpan.FromSeconds(5));
//servo.WritePulseWidth(90); // ~1.5ms; Approximately 90 degrees.
//await Task.Delay(TimeSpan.FromSeconds(5));
servo.WriteAngle(90); // ~2.1ms; Approximately 180 degrees.

Thread.Sleep(2000);

//await Task.Delay(TimeSpan.FromSeconds(5));

/* System.Console.WriteLine("Write angle 90");

servo.WriteAngle(60);

await Task.Delay(TimeSpan.FromSeconds(5));

System.Console.WriteLine("Write angle 0");
servo.WriteAngle(0);

await Task.Delay(TimeSpan.FromSeconds(5));
System.Console.WriteLine("Write angle 90");
servo.WriteAngle(0);

await Task.Delay(TimeSpan.FromSeconds(5));

System.Console.WriteLine("Write angle 0");
servo.WriteAngle(0);

await Task.Delay(TimeSpan.FromSeconds(5));

System.Console.WriteLine("Write angle 90");
servo.WriteAngle(90); */

System.Console.WriteLine("Done with it !!");

servo.Stop();  // Enable control signal.

/* int pulseWidthMinimum = 500; // Minimum pulse width (in microseconds)
int pulseWidthMaximum = 2500; // Maximum pulse width (in microseconds)

using (var motorHat = new MotorHat())
{
    // Create a servo motor on channel 1 (corresponding to GPIO 18)
    var servoMotor = motorHat.CreateServoMotor(1, minimumPulseWidthMicroseconds: pulseWidthMinimum, maximumPulseWidthMicroseconds: pulseWidthMaximum);

    // Run the servo motor back and forth a few times
    servoMotor.Start();

    for (int i = 0; i < 5; i++)
    {
        // Move the servo to the minimum position
        servoMotor.WriteAngle(10);
        Thread.Sleep(1000);

        // Move the servo to the maximum position
        //servoMotor.SetPulseWidth(pulseWidthMaximum);
        Thread.Sleep(1000);
    }

    // Stop the servo motor
    servoMotor.Stop();
} */

/* List<int> validAddress = new List<int>();
Console.WriteLine("Hello I2C!");
// First 8 I2C addresses are reserved, last one is 0x7F
for (int i = 8; i < 0x80; i++)
{
    try
    {
        I2cDevice i2c = I2cDevice.Create(new I2cConnectionSettings(1, i));
        var read = i2c.ReadByte();
        validAddress.Add(i);
    }
    catch (Exception ex)
    {
        // Do nothing, there is just no device
        System.Console.WriteLine($"Eception: [{ex.Message}]");
    }
}

Console.WriteLine($"Found {validAddress.Count} device(s).");

foreach (var valid in validAddress)
{
    Console.WriteLine($"Address: 0x{valid:X}");
} */