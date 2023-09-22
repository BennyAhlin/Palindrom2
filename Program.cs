Console.WriteLine();
Console.WriteLine("Hello there! Please write a sentence.");
Console.WriteLine();
Console.Clear();
string word = Console.ReadLine();
string reverse = string.Empty;
string newWord = string.Empty;

for (int k = 0; k < word.Length ; k++)
{                               //räknar +1
    bool omfalsk = false; //startar som falsk

    if (word[k].ToString() == "," || word[k].ToString() == "." || word[k].ToString() == " ")
    {
        omfalsk = true; //om falsk = true (bryter och börjar räkna igen)
    }
    if (!omfalsk) //om inte falsk!!
    {
    newWord += word[k].ToString();
    }
}

for (int i = word.Length -1; i >= 0; i--)
{

    if (word[i].ToString() == "," || word[i].ToString() == "." || word[i].ToString() == " ")
    {
        continue;
    }
    reverse += word[i].ToString();
}

Console.WriteLine(reverse);

if (newWord.Equals(reverse, StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine();
    Console.WriteLine("Correct! The sentence you wrote was: --" + word + "-- This is a palindrom!");
    Console.WriteLine();
    Console.WriteLine();
}

else
{
    Console.WriteLine();
    Console.WriteLine("Sorry. The sentence you wrote was: --" + word + "-- This is NOT a palindrom");
    Console.WriteLine();
    Console.WriteLine();
}

