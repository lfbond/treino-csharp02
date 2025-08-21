/* //Exemplo 01 - Sub. 01 - Und. 01 a 03
Console.WriteLine("a" == "a ");
Console.WriteLine("a" == "A");
Console.WriteLine("1" == "2");

string myValue = "a";
Console.WriteLine(myValue == "a"); */

/* //Exemplo 02 - Sub. 01 - Und. 01 a 03
string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); */

/* //Exemplo 03 - Sub. 01 - Und. 01 a 03
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a"); */

/* //Exemplo 04 - Sub. 01 - Und. 01 a 03
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1); */

/* //Exemplo 05 - Sub. 01 - Und. 01 a 03
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox")); */

/* //Exemplo 06 - Sub. 01 - Und. 01 a 03
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False */

/* //Exemplo 07 - Sub. 01 - Und. 01 a 03
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}"); */

/* //Exemplo 08 - Sub. 01 - Und. 01 a 03
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); */

/* //Exercício 01 - Sub. 01 - Und. 04 e 05
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails"); */

/* //Exercício 02 - Sub. 01 - Und. 04 e 05
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails"); */

//Exemplo 01 - Sub. 01 - Und. 06 a 09
string permission = "Admin | Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level >= 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level <= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}