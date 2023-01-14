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
string answer1 = string.Format("my name is {0} and my name reversed is {1}",name,reversedName);
Console.WriteLine(answer1);

// task 2

int answer2 = 0;
Console.WriteLine("Please insert an integer");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter s to calculate the sum from 1 to selected number or p for the product");
string c2 = Console.ReadLine();
if(c2 == "s" )
{
    for(int i = 0; i <= num2; i++)
    {
        answer2 += i;
    }
    String.Format("The sum from 1 to {0} is {1}",num2,answer2);
}
if(c2=="p")
{
    for (int i = 0; i <= num2; i++)
    {
        answer2 = answer2 * i;
    }
    String.Format("The product from 1 to {0} is {1}", num2, answer2);
}



