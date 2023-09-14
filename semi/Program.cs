// See https://aka.ms/new-console-template for more information

Console.Write("Enter number : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number : ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

int sqr = num2 * num2;

if (sqr == num1)
{
System.Console.WriteLine("Да");
}
else
{
  System.Console.WriteLine("Нет");
}