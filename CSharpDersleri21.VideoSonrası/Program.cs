//21. Ders Videosu

int[] ints = new int[4];
ints[0] = 1;
ints[1] = 2;
ints[2] = 3;
ints[3] = 4;

static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int number1,int number2)
{
    return number1 + number2;
}

static int Add3(int number1,int number2=20)
{
    return (number1 + number2);
}
static int Multiply(int number5, int number4, int number3)
{
    return number4 * number5 * number3;
}

static int Add4(int number2,params int[] numbers)
{
  return numbers.Sum();
}

Add();
Console.WriteLine(Add2(1, 3));
Console.WriteLine(Add3(25));
Console.WriteLine(Multiply(2,4,6));
Console.WriteLine(Add4(2,ints));
