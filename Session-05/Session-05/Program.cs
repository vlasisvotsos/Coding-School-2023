// task 1

string name = "vlasis";
char[] charArray = new char[name.Length];
char[] help = new char[name.Length];
for (int i = 0; i < charArray.Length; i++)
{
    charArray[i] = name[i];
    help[i] = name[i];
}
for (int i=0;i< charArray.Length; i++)
{
    charArray[i] = help[charArray.Length - i -1];
}
   string reversedName = new string(charArray);
string answer = string.Format("my name is {0} and my name reversed is {1}",name,reversedName);
Console.WriteLine(answer);

// task 2

Console.WriteLine("Please insert an integer");
int j = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please enter s to calculate the sum from 1 to selected number or p for the product");
//char c = Convert.ToChar(Console.ReadLine());


