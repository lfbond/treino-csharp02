/* //Exemplo 01
Console.WriteLine("a" == "a ");
Console.WriteLine("a" == "A");
Console.WriteLine("1" == "2");

string myValue = "a";
Console.WriteLine(myValue == "a"); */

/* //Exemplo 02
string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); */

/* //Exemplo 03
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a"); */

/* //Exemplo 04
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1); */

/* //Exemplo 05
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox")); */

//Exemplo 06
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False