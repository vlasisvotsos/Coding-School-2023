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

int sum2 = 0;
int product2 = 1;
Console.WriteLine("Please insert an integer");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Format("Please enter 0 to calculate the sum from 1 to {0} or 1 for the product", num2));
int c2 = Convert.ToInt32(Console.ReadLine());
if (c2 == 0 )
{
    for(int i = 0; i <= num2; i++)
    {
        sum2 += i;
    }
    Console.WriteLine(String.Format("The sum from 1 to {0} is {1}" , num2 , sum2));
}
if(c2== 1)
{
    for (int i = 1; i <= num2; i++)
    {
        product2 = product2 * i;
    }
    Console.WriteLine(String.Format("The product from 1 to {0} is {1}" , num2 , product2));
}

// task 3


