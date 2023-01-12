//task 1

using System.Security.Cryptography;

Console.WriteLine("Hello Vlasis");

//task 2

int a2 = 1;
int b2 = 2;
int sum2 = a2 + b2;
Console.WriteLine(sum2);

//task 3

int a3 = -1 + 5 * 6;
Console.WriteLine(a3);
int b3 = 38 + 5 % 7;
Console.WriteLine(b3);
int c3 = 14 + (-3 * 6) / (7);
Console.WriteLine(c3);
int d3 = 2 + 13 / 6 * 6 + (int)Math.Sqrt(7);
Console.WriteLine(d3);
int e3 = (int)(Math.Pow(6, 4) + Math.Pow(5, 7)) /(9 % 4);
Console.WriteLine(e3);

//task 4
string gender = "male";
int age = 29;
Console.WriteLine("You are " + gender + "  and look younger than " + age + ".");

// task 5

int sec = 45678;
Console.WriteLine(sec + " seconds is " + sec / 60 + " minutes and " + sec % 60 + " seconds.");
Console.WriteLine(sec + " seconds is " + sec / 3600 + " hours and " + (sec % 3600) / 60 + " minutes and " + ((sec % 3600) / 60) % 60 + " seconds.");
Console.WriteLine(sec + " seconds is " + sec / 86400 + " days and " + (sec % 86400) / 3600 + " hours and " + (((sec % 86400) / 3600) % 3600) / 60 + " minutes and " + (((sec % 86400 / 3600) % 3600) / 60) % 60 + " seconds.");
Console.WriteLine(sec + " seconds is 0 years and " + sec / 86400 + " days and " + (sec % 86400) / 3600 + " hours and " + (((sec % 86400) / 3600) % 3600) / 60 + " minutes and " + (((sec % 86400 / 3600) % 3600) / 60) % 60 + " seconds.");

// task 6
TimeSpan t = TimeSpan.FromSeconds(sec);

Console.WriteLine(t.Hours);

Console.WriteLine(t.Minutes);

Console.WriteLine(t.Seconds);

Console.WriteLine(t.ToString());