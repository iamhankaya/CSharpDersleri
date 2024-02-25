//15. Ders Videosu

var number = 11;

if (number == 10)
{
    Console.WriteLine("Number is : " + number);
}
else
{
    Console.WriteLine("Number is not 10");
}

//16. Ders Videosu

Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

//17.Ders Videosu

if (number == 11)
{
    Console.WriteLine("Number is 11");

}
else if (number == 12)
{
    Console.WriteLine("Number is 12");
}
else
{
    Console.WriteLine("Number is not 11 or 12");
}

//18. Ders Videosu

int number1 = 13;
switch (number1)
{
    case 13:
        Console.WriteLine("sa");
        break;
    case 14:
        Console.WriteLine("as");
        break;
    default:
        Console.WriteLine("Wrong Number Entry! Please try again ");
        break;
}

//19. Ders Videosu

if(number1>=0 && number1<=100)
{
    Console.WriteLine("Number1 is between 0-100");
}
else if(number1>100 && number1<=200)
{
    Console.WriteLine("Number1 is between 101-200");
}
else if(number1>200 || number1<0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

//20. Ders Videosu

if (number1<100)
{
    if(number1>=90)
    {
        Console.WriteLine("Number is between 90-100");
    }
    else
    {
        Console.WriteLine("Number is less than 90");
    }
}

