// task 1

string name = "vlasis";
// Console.WriteLine(name);

char[] charArray = new char[name.Length];
char[] help = new char[name.Length];
for (int i = 0; i < charArray.Length; i++)
{
    charArray[i] = name[i];
    help[i] = name[i];
    Console.WriteLine(charArray[i]);
}

Console.ReadLine();

