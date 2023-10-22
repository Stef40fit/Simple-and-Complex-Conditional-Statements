//From the console read: season(string), accommodation type(string) and count of the days (integer)
//Season will be one of the following: "Spring", "Summer", "Autumn" and "Winter"
//Accommodation type will be one of the following: "Hotel" and "Camping
//Based on the table below, you have to calculate expenses for the vacation with the given accommodation type, season and count of the days. 
//For the calculation: use price per night (extracted from the table below) multiplied by count of the days.
//Print the total expenses, formatted to the second digit after the decimal point


string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double expenses = 0;

if (season == "Spring" && accommodation == "Hotel")
{
    expenses = (days * 30) * 0.8;
    Console.WriteLine($"{expenses:f2}");
}
else if (season == "Spring" && accommodation == "Camping")
{
    expenses = (days * 10) * 0.8;
    Console.WriteLine($"{expenses:f2}");
}
else if (season == "Summer" && accommodation == "Hotel")
{
    expenses = (days * 50);
    Console.WriteLine($"{expenses:f2}");
}
else if (season == "Summer" && accommodation == "Camping")
{
    expenses = (days * 30);
    Console.WriteLine($"{expenses:f2}");
}

else if (season == "Autumn" && accommodation == "Hotel")
{
    expenses = (days * 20) * 0.7;
    Console.WriteLine($"{expenses:f2}");
}
else if (season == "Autumn" && accommodation == "Camping")
{
    expenses = (days * 15) * 0.7;
    Console.WriteLine($"{expenses:f2}");
}

else if (season == "Winter" && accommodation == "Hotel")
{
    expenses = (days * 40) * 0.9;
    Console.WriteLine($"{expenses:f2}");
}
else if (season == "Winter" && accommodation == "Camping")
{
    expenses = (days * 10) * 0.9;
    Console.WriteLine($"{expenses:f2}");
}

