//•	A given number is valid if it is in the range [100...200] or it is equals to 0. 
//•	Write a program that:
//•	Reads an integer from the console
//•	 Prints "invalid" if the entered number is NOT valid

using System.ComponentModel.Design;

int num = int.Parse(Console.ReadLine());

if ((num < 100 || num > 200 )&& num != 0)
{
    Console.WriteLine("invalid");
}