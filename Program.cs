/* //Exemplo 01 - Sub. 02 - Und. 01 a 04
bool flag = true;
int value = 0;
if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}"); */

/* //exemplo 02 - Sub. 02 - Und. 01 a 04
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

 int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}"); 

int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}"); 

 int value;
Console.WriteLine($"Outside the code block: {value}");

int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}"); */

/* //Exemplo 03 - Sub. 02 - Und. 01 a 04
bool flag = true;
if (flag) Console.WriteLine(flag); 

string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");*/


//Exemplo 04 - Sub. 02 - Und. 01 a 04
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
    }
}

if (found) 
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");

