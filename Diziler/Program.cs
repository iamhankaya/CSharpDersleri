string student1 = "Engin";
string student2 = "Derin";
string student3 = "Salih";

string[] students = new string[3];
students[0] = student1;
students[1] = student2;
students[2] = student3; 

string[] students2 = { student1, student2,student3 };

string[] students3 = new string[3] {student1,student2,student3};

string[,] regions = new string[7, 3]
{
    {"İstanbul","İzmit","Balıkesir"},
    {"","","asd"},
    {"","",""},
    {"","",""},
    {"","",""},
    {"","",""},
    {"","",""}

};

foreach (string s in students)
{

    Console.WriteLine(s);
}

for(int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
}