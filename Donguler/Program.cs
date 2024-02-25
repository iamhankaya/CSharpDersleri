using System.Runtime.CompilerServices;

for (int i = 1; i <= 100; i++)
{
    //Console.WriteLine(i);
}

int number = 100;
int number2 = 20;

while (number>=0)
{
    // Console.WriteLine(number);
    number--;
}

do
{
    //Console.WriteLine(number2);

    number2--;
} while (number2 >= 0);

static bool IsPrimeNumber(int number)
{
    bool result = true;

    for(int i = 2;i <= number; i++)
    {
        if(number%i == 0)
        {
            if (i == number)
            {
                continue;
            }
            result = false;
            return result; 
        }

    }
    return result;
}

Console.WriteLine(IsPrimeNumber(99));