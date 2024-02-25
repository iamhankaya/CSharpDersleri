string city = "Ankara";

//Console.WriteLine(city[0]);

foreach (var item in city)
{
    Console.WriteLine(item);
}

string city2 = "Istanbul";
//string result = city + city2;

Console.WriteLine(String.Format("{0} {1}",city,city2));

string sentence = "My name is Metehan Kaya";

var result = sentence.Length;
var result2 = sentence.Clone();
bool result3 = sentence.EndsWith("M");
bool result4 = sentence.StartsWith("M");
var result5 = sentence.IndexOf("M");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(5);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","-");
var result13 = sentence.Remove(2,4);

//string sentence2 = "My name is Metohanhan";
Console.WriteLine(result13);