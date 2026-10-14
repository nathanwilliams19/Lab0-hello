Console.Write("How many students do you have to enter? ");
int numStudents = Convert.ToInt32(Console.ReadLine());

if(numStudents > 10)
{
    numStudents = 10;
}

string[] students = new string[numStudents];


//limit this to 10 or less
for(int i = 0; i < numStudents; i++)
{
    if((i + 1) == 1)//first student
    {
         System.Console.WriteLine($"Enter the name for {i + 1}st student: ");
    }
    
    else if((i + 1) == 2)//second
    {
        System.Console.WriteLine($"Enter the name for {i + 1}nd student: ");
    }
    
    else if((i + 1) ==3)//third
    {
        System.Console.WriteLine($"Enter the name for {i + 1}rd student: ");
    }
    
    else if((i + 1) >= 4)//thrid
    System.Console.WriteLine($"Enter the name for {i + 1}th student: ");

    students[i] = Console.ReadLine().Trim();
}



Console.Write("Please give me your first name. ");
string firstName = Console.ReadLine();

Console.Write("Please give me your last name. ");
string lastName = Console.ReadLine();

string userName = MakeUsername(firstName, lastName);

System.Console.WriteLine($"Your user name is {userName}.");

int studentId = MakeUserId();
int studentLockerNumber = GetLockerNumber();
int checkDigit = CheckDigit(studentId);




static int MakeUserId()
{
    Random rng = new Random();
    return rng.Next(10000, 1000000);
}

static int GetLockerNumber()
{
    Random rng = new Random();
    return rng.Next(1, 501);
}

static string[] MakeUsernameFromArray(string[] names)
{
    for(int i = 0; i < names.Length, i++)
    {
        string[] nameSplit = names[i].Split(" "); //Nathan Williams
        userNames[i] = MakeUserName(nameSplit[0], nameSplit[1]);
    }
   
    string[] nameSplit = names[0].Split(" "); //Nathan Williams
    //nameSplit[0] = Nathan
    //nameSplit[1] = Williams
}











static string MakeUsername(string firstName, string lastName)
{
    string userName = "";

    userName += firstName.ToLower()[0];
    userName += lastName.ToLower();

    return userName;
}

static int CheckDigit(int studentId)
{
    return studentId % 9;
}

static double WalkDistance(double x1, double y1, double x2, double y2)
{
    distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));   
}

static int WalkTimeInMinutes(double distance, double speed)
{

    return (int)((distance / speed) / 60);
}

static int WalkTimeInSeconds(double distance, double speed)
{

    return (int)((distance / speed) % 60);
}

static string MessageForWalkTime(int minutes, int seconds)
{
    return $" {minutes} minutes {seconds} seconds";
}


