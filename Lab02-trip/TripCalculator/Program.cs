using System.Numerics;

Console.Write("How many miles did you travel");
int roundTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon for the car you traveled in");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What was the average price per gallon you paid");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTrip / milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

Console.Write("How many people are going");
double amountPeople = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas were brought");
double amountPizzas = Convert.ToDouble(Console.ReadLine());

Console.Write("How much was the average price for each pizza");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

int pizza;
pizza=8;

double totalSlices = amountPizzas * pizza;
double slicesPerPerson = totalSlices / amountPeople;
double pizzaCost = amountPizzas * pricePerPizza;

Console.WriteLine("Total slices: " + totalSlices.ToString("F"));
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));

Console.WriteLine("How many hours did you work this week");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is yoiur hourly rate");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

double taxRate;
taxRate = .18;

double grossPay = hoursWorked * hourlyRate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / amountPeople;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work: " + hoursYouMustWork.ToString("F2"));



