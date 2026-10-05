/*
Name: Nathan Williams
Course: CSCI 1250, Section 001
Assignment: Lab 03, The Badge Office
Date: September 30, 2026
Description: Builds a student badge from a name, two random assignments, and the walking distance to first class.
*/

string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf (" ");
string firstName = fullName.Substring (0, spacePosition);
string lastName = fullName.Substring (spacePosition + 1);

string badgeName = fullName.ToUpper();
string userName = (firstName.Substring(0,1) + lastName).ToLower();
string initials = firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper() + ".";

Random rng = new Random ();

int studentID = rng.Next (100000,999999);
int locker = rng.Next (1, 50);


int checkDigit = studentID % 9;
string bar = new string('=', 34);

Console.Write("\nFull name:".PadRight(10) + fullName);
Console.Write ("Name on badge:".PadRight(10) + badgeName);
Console.Write("username".PadRight(10) + userName);
Console.Write("Intials:".PadRight(10) + initials);
Console.Write("Letters in Last Name:".PadRight(10) + lastName.Length);

Console.WriteLine("\nStudent ID:".PadRight(10) + studentID);
Console.WriteLine("Locker:".PadRight(10) + locker);

Console.Write("\nDorm x: ");
double dormX = Convert.ToDouble (Console.ReadLine());

Console.Write ("Dormy: ");
double dormY = Convert.ToDouble (Console.ReadLine());

Console.Write ("Class x: ");
double classroomX = Convert.ToDouble (Console.ReadLine());

Console.Write ("Class y: ");
double classroomY = Convert.ToDouble (Console.ReadLine());

Console.Write ("Walking speed in feet per second: ");
double walkingSpeed = Convert.ToDouble (Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(classroomX - dormX, 2) + Math.Pow(classroomY - dormY, 2));
int totalSeconds = (int)Math.Round(distance / walkingSpeed);
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

Console.Write("\nDistance:".PadRight(10) + distance);
Console.Write("\nWalk time:".PadRight(10) + minutes + " minutes " + seconds + " seconds \n");


Console.WriteLine(bar);
Console.WriteLine("ETSU STUDENT BADGE".PadLeft(26));
Console.WriteLine(bar);
Console.WriteLine("NAME" .PadRight(10) + fullName.ToUpper());
Console.WriteLine("USERNAME".PadRight(10) + userName);
Console.WriteLine("ID".PadRight(10) + userName);
Console.WriteLine("LOCKER".PadRight(10) + locker);
Console.WriteLine("WALK".PadRight(10) + minutes + " Minutes " + seconds + "Seconds");
Console.WriteLine(bar);

