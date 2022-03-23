// See https://aka.ms/new-console-template for more information


/*1.Create a console application project named /02UnderstandingTypes/ that outputs the 
number of bytes in memory that each of the following number types uses, and the minimum and maximum values they can have: 
sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.*/
Console.WriteLine("sbyte Max Value:{0}, Min Value:{1}", sbyte.MaxValue, sbyte.MinValue);
Console.WriteLine("byte Max Value:{0}, Min Value:{1}", byte.MaxValue, byte.MinValue);
Console.WriteLine("short Max Value:{0}, Min Value:{1}", short.MaxValue, short.MinValue);
Console.WriteLine("ushort Max Value:{0}, Min Value:{1}", ushort.MaxValue, ushort.MinValue);
Console.WriteLine("int Max Value:{0}, Min Value:{1}", int.MaxValue, int.MinValue);
Console.WriteLine("uint Max Value:{0}, Min Value:{1}", uint.MaxValue, uint.MinValue);
Console.WriteLine("long Max Value:{0}, Min Value:{1}", long.MaxValue, long.MinValue);
Console.WriteLine("ulong Max Value:{0}, Min Value:{1}", ulong.MaxValue, ulong.MinValue);
Console.WriteLine("float Max Value:{0}, Min Value:{1}", float.MaxValue, float.MinValue);
Console.WriteLine("double Max Value:{0}, Min Value:{1}", double.MaxValue, double.MinValue);
Console.WriteLine("decimal Max Value:{0}, Min Value:{1}", decimal.MaxValue, decimal.MinValue);




/*2.Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.  
 * Use an appropriate data type for every data conversion. Beware of overflows!*/

int num;
Console.WriteLine("Enter an integer number of centuries");
//Centruies
num = Convert.ToInt32(Console.ReadLine());

//Years
ushort numYears = (ushort)(num * 100);

//Days
decimal numDays = (decimal)(numYears * 365.24);

//Hours
uint numHours = (uint)(numDays * 24);

//Minutes
ulong numMinutes = numHours * 60;

//Seconds
ulong numSeconds = numMinutes * 60;

//Milliseconds
decimal numMilliseconds = (numSeconds * 1000);

//Microseconds
decimal numMicroseconds = (numMilliseconds * 1000);

//Nanoseconds
decimal numNanoseconds = (numMicroseconds * 1000);

Console.WriteLine($"{num} Centruies = {numYears} Years = {numDays} Days = {numHours} Hours = {numMinutes} Minutes = {numSeconds} Seconds = {numMilliseconds} Milliseconds = {numMicroseconds} Microseconds = {numNanoseconds} Nanoseconds");