// See https://aka.ms/new-console-template for more information
Console.WriteLine("X Value for Camera");
var x = Console.ReadLine();
Console.WriteLine("Y Value for Camera");
var y = Console.ReadLine();
Console.WriteLine("Z value for camera");
var z = Console.ReadLine();
Console.WriteLine("Seconds for running the simulation");
var sec = Console.ReadLine();
var secp = int.Parse(sec);
var xp = int.Parse(x);
var yp = int.Parse(y);
var zp = int.Parse(z);

for (int i = 1; i < secp; i++)
{
    int v = xp * 299792458 * i;
    int vx = yp * 299792458 * i;
    int vxx = zp * 299792458 * i;
    Console.WriteLine("X Value:");
    Console.WriteLine(v);
    Console.WriteLine("Y Value:");
    Console.WriteLine(vx);
    Console.WriteLine("Z Value:");
    Console.WriteLine(vxx);
    if(v > 2000)
    {
       v = xp * -299792458 * i;
    }
    if(v < -2000)
    {
        v = xp * 299792458 * i;
    }
    if(vx > 2000)
    {
        vx = yp * 299792458 * i;
    }
    if(vx < -2000)
    {
        vx = yp * -299792458 * i;
    }
    if(vxx > 2000)
    {
        vxx = zp * 299792458 * i;
    }
    if(vxx < -2000)
    {
        vxx = zp * -299792458 * i;
    }
}
