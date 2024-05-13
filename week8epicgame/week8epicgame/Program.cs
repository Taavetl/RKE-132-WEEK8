using System.ComponentModel.Design;
using System.Runtime.InteropServices;

string folderpath = @"C:\\Users\\Taavet\\Downloads\\dataa\";
string herofile = "heroes.txt";
string villainfile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderpath, herofile));
string[] villains = File.ReadAllLines(Path.Combine(folderpath, villainfile));




//string[] heroes = {"harry", "luke", "lara", "scooby" };
//string[] villains = {"voldemort", "vader", "dracula", "joker", "suron" };
string[] weapon = {"wand", "fork", "banana", "sword", "brick" };

string hero = getrandomvaluefromarray(heroes);
string herpweapon = getrandomvaluefromarray(weapon);
Console.WriteLine($"today {hero} ({herohp} hp) with {herpweapon}tries to save the day!");

string villain = getrandomvaluefromarray(villains);
string villainsweapon = getrandomvaluefromarray(weapon);
Console.WriteLine($"today{villains} ({villainhp} hp) with {villainsweapon}tries to take over the world!");
static string getrandomvaluefromarray(string[] somearray)
{
    Random rnd = new Random();
    int randomindex = rnd.Next(0, somearray.Length);
    string randomstringfromarray = somearray[randomindex];
    return randomstringfromarray;
        }

while(herohp > 0 && villainhp > 0)
{
    herohp = herohp - hit(villain, villainhp);
    villainhp = villainhp - hit(hero, herohp);
}

Console.WriteLine($"hero {hero} hp: {herohp}");
Console.WriteLine($"villain {villain} hp: {villainhp}");

if(herohp > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if ( villainhp > 0)
{
    Console.WriteLine($"dark side wins!");

}
else
{
    Console.WriteLine("draw!");
}

static string getrandomvaluefromarray(string[] somearray)
{
    Random rnd = new Random();
    int randomindex = rnd.Next(0, somearray.Length);
    string randomstringfromarray = somearray[randomindex];
    return randomstringfromarray;

}

static int getcharecterhp(string charectername)
{
    if (charectername.Length < 10)
    {
        return 10;

    }else
    {
        return charectername.Length;
    }
}

static int hit(string charectername, int charecterhp)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, charecterhp);
    if(strike == 0)
    {
        Console.WriteLine($"{charectername} made a critical hit!");

    }else if (strike == charecterhp - 1)
    {
        Console.WriteLine($"{charectername} hit {strike}!");
    }
}return strike;


