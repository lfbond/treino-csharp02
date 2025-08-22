/* //Exemplo 01 - Sub. 04 - Und. 01 a 04

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
} */

/* //Exemplo 02 - Sub 04 - Und. 01 a 04
for (int i = 0; i <= 10; i += 5)
{
    Console.WriteLine(i);
} */

/* //Exemplo 03 - Sub. 4 - Und. 01 a 04
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
} */

/* //Exemplo 04 - Sub. 4 - Und. 01 a 04
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
} */

/* //Exemplo 05 - Sub. 4 - Und. 01 a 04
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

//Exemplo 05 cont.1 - Sub. 4 - Und. 01 a 04
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name); 

//Exemplo 05 cont.2 - Sub. 4 - Und. 01 a 04

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
} */

/* //Exemplo 06 - Sub. 4 - Und. 01 a 04
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
} */

//Exemplo 07 - Sub. 4 - Und. 01 a 04
