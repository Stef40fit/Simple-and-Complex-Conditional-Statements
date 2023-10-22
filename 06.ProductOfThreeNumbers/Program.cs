//Write a program that calculates the sign of the product of three numbers:
//Reads 3 real numbers from the console
//Print the sign of the product of the three given numbers: "positive", "negative" or "zero"
//Note: Try to do this without multiplying the numbers.

double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());
int countnegative = 0;
if (num1 == 0 || num2 == 0 || num3 == 0)
{
    Console.WriteLine("zero");
}   
else
{
     if (num1 < 0)
    {
        countnegative++;
    }
    if (num2 < 0)
    {
        countnegative++;
    }
    if (num3 < 0)
    {
        countnegative++;
    }
    if(countnegative == 0 || countnegative == 2)
    {
        Console.WriteLine("positive");
    }
    if(countnegative == 1 || countnegative == 3)
    {
        Console.WriteLine("negative");
    }
}
