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

Console.WriteLine("Please insert an integer");
int num3 = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i < num3;i++)
{
    Boolean check = true;
    for(int j=2; j < i; j++)
    {
        if (i%j==0)
        {
            check= false;
            break;
        }
    }
    if (check)
    {
        Console.WriteLine(i);
    }
}

// task 4

int counter = 0;
int[] array1 = new int[4];
int[] array2 = new int[4];
int[] answer4= new int[16];
array1[0] = 2;
array2[0] = 1;
array1[1] = 4;
array2[1] = 3;
array1[2] = 9;
array2[2] = 7;
array1[3] = 12;
array2[3] = 10;
for(int i = 0;i< array1.Length; i++)
{
    for(int j = 0; j < array2.Length; j++)
    {
        answer4[counter] = array1[i] * array2[j];
        counter++;
    }
}
for (int i = 0; i < answer4.Length; i++)
{
    Console.WriteLine(answer4[i]);
}

// task 5


int[] unSortedArray = new int[10];
int[] sortedArray = new int[10];
int test=0;
unSortedArray[0] = 0;
unSortedArray[1] = -2;
unSortedArray[2] = 1;
unSortedArray[3] = 20;
unSortedArray[4] = -31;
unSortedArray[5] = 50;
unSortedArray[6] = -4;
unSortedArray[7] = 17;
unSortedArray[8] = 89;
unSortedArray[9] = 100;
for(int i =0; i< unSortedArray.Length; i++)
{
    test = unSortedArray[i];
    for(int j = 0; j < unSortedArray.Length; j++)
    {
        if (test < unSortedArray[j])
        {
            sortedArray[i] = test;
        }
        else
        {
            test = unSortedArray[j];
        }
    }
}
Console.WriteLine("the unsorted array is");
for (int i = 0; i < unSortedArray.Length; i++)
{
    Console.WriteLine(unSortedArray[i]);
}
Console.WriteLine("and the sorted  array is");
for (int i = 0; i < sortedArray.Length; i++)
{
    Console.WriteLine(sortedArray[i]);
}