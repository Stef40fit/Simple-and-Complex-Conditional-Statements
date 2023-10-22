            //Reads an integer number from the console
            //Based on the given number:
            //Print "negative", if the number is lower than zero
            //Print "positive ", if the number is bigger than zero
            //Print "zero ", if the number is equals to zero
int numType = int.Parse(Console.ReadLine());
if (numType < 0)
{
    Console.WriteLine("negative");
}
else if (numType > 0)
{
    Console.WriteLine("positive");
}
else
{
    Console.WriteLine("zero");
}

