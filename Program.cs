/*
Random generator = new Random();
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(generator.Next(0, 10));
    //cisla se vypisi od 1 do 9

}

using System;
using System.Reflection.Metadata.Ecma335;

Random generator = new Random();
bool a = true;
while (a)
{
    string b = Console.ReadLine();
    if (b == "ano")
    {
        Console.WriteLine(generator.Next(1, 100000000));
    }
    else
    {
        a = false;
    }
}
int d = 0;
for (int i = 0; i <10; i++)
{
    int e = generator.Next(1, 10);
    Console.WriteLine(e);
    d += e;
    Console.WriteLine(d);

}
/*
Random generator = new Random();
bool m = true;
string o = "";
while (m)
{
    int n = generator.Next(0, 32); 
   string input = Console.ReadLine();
    if (n == 32)
    {
        o += " ";
        Console.WriteLine(o);
    }
    
    else if (input == "ano")
    {
        char nahodnePismeno = (char)('a' + generator.Next(0, 26));
        o += nahodnePismeno;
        Console.WriteLine(o);
    }
    
    else if (input == "ne")
    {
        m = false;
    }
   
}
*/
using System.Reflection.Emit;
Random generator = new Random();
bool a = true;
int b = 0;
string c = "";
while (a)
{
    char nahodnePismeno = (char)('a' + b);
    b++;
    Console.WriteLine(nahodnePismeno);
    if (nahodnePismeno == 'h')
    {
        c += nahodnePismeno;
        a = false;
    }
}
a = true;



