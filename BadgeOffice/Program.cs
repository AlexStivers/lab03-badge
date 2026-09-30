/*
* Name: Alex Stivers
* Course: CSCI 1250, Section 001
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
*              and the walking distance to a first class
*/

//Part 1: Name
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("What is your name?");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string badgeName = fullName.ToUpper();
string userName = (firstName.Substring(0, 1) + lastName);
string initials = $"{firstName.Substring(0, 1).ToUpper()}.{lastName.Substring(0, 1).ToUpper()}.";
int lastNameLength = lastName.Length;

Console.WriteLine($"Name on badge: {badgeName}");
Console.WriteLine($"Username: {userName}");
Console.WriteLine($"Initials: {initials}");
Console.WriteLine($"Letters in last name: {lastNameLength}");
Console.WriteLine();

//Part 2: The Numbers
Random rng = new Random();
int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

Console.WriteLine($"Student ID: {studentId}");
Console.WriteLine($"Locker: {lockerNumber}");
Console.WriteLine();

//Part 3: The Walk
Console.Write("Dorm x: ");
double dormX = double.Parse(Console.ReadLine());

Console.Write("Dorm y: ");
double dormY = double.Parse(Console.ReadLine());

Console.Write("Class x: ");
double classX = double.Parse(Console.ReadLine());

Console.Write("Class y: ");
double classY = double.Parse(Console.ReadLine());

Console.Write("Walking speed in feet per second: ");
double speed = double.Parse(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(classX - dormX, 2)) + Math.Pow(classY - dormY, 2));
double roundedDistance = Math.Round(distance, 1);

int totalSeconds = (int)(distance / speed);
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

Console.WriteLine();
Console.WriteLine($"Distance: {roundedDistance:F1} feet");
Console.WriteLine($"Walk time: {minutes} minutes {seconds} seconds");
Console.WriteLine();

//Part 4: Badge
int checkDigit = studentId % 9;
string fullId = $"{studentId}-{checkDigit}";

string border = new string('=', 34);

Console.WriteLine(border);
Console.WriteLine("       ETSU STUDENT BADGE");
Console.WriteLine(border);
Console.WriteLine($"{"NAME".PadRight(10)}{badgeName}");
Console.WriteLine($"{"USERNAME".PadRight(10)}{userName}");
Console.WriteLine($"{"ID".PadRight(10)}{fullId}");
Console.WriteLine($"{"LOCKER".PadRight(10)}{lockerNumber}");
Console.WriteLine($"{"WALK".PadRight(10)}{minutes} min {seconds} sec");
Console.WriteLine(border);