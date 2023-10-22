//Reads an hour of the day (integer number) and a day of the week (string)
//The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive.
//Print "open", if the office is open in the given hour and day of the week
//Print "closed", if the office is closed in the given hour and day of the week



int houreOfDays = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (dayOfWeek == "Sunday")
{
    Console.WriteLine("closed");
}
else
{
    if (houreOfDays >= 10 && houreOfDays <= 18)
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }
}

//if (houreOfDays >= 10 && houreOfDays <= 18)
//{
//    if (dayOfWeek == "Tuesday" && dayOfWeek == "Wednesday" && dayOfWeek == "Thursday" && dayOfWeek == "Friday" && dayOfWeek == "Saturday")
//    {
//        Console.WriteLine("open");
//    }

//}
//else
//{
//    Console.WriteLine("closed");
//}
