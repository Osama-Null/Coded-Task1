// a.t1
int a = 9;
double b = 23.9;
string c = "Preeviet";
bool d = true;

Console.WriteLine(a + "\t" + b + "\t" + c + "\t" + d);
Console.WriteLine("\n______________________\n");
// a.t2+bonus
int e = 7;
double f = Convert.ToDouble(e);

char g = '+';
Console.WriteLine(e + "\t" + f + "\t" + g);
Console.WriteLine("\n______________________\n");

// b.t1
Console.Write("\nEnter your Name: ");
string studentName = Console.ReadLine();
Console.Write("\nEnter your Average: ");
float studentAvg = float.Parse(Console.ReadLine());
Console.Write("\nEnter your favorite Subject: ");
string studentSub = Console.ReadLine();

Console.WriteLine(studentName + "\t" + studentAvg + "\t" + studentSub);
Console.WriteLine("\n______________________\n");

// b.t2+bonus
double width = 5.5, height = 3.2;
double regArea = width * height;

Console.WriteLine("\nWidth: " + width + "\tHeigt: " + height + "\n\nThe area of a rectangle: " + regArea);

const int max = 9; // read-only
Console.WriteLine("\n______________________\n");

// c.ch1
int time = DateTime.Now.Hour;
DateTime cuTime = DateTime.Now;

Console.WriteLine("Date & Time: " + cuTime);
if (time >= 11 && time <= 14)
{
    Console.WriteLine("\n\t...Time for lunch!");
}
else Console.WriteLine("\n\t...Not lunchtime yet.");
