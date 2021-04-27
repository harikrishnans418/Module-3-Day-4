using System;
namespace Day_4
{
class MyException:ApplicationException
{
public void MyDivideException()
{
Console.WriteLine("An Exception occurred,divsor should not be zero");
}

}
class Class6
{
public static void Main()
{
int x = 5, y = 0, z;
try
{
if(y==0)
{
throw new Myexception();
}
}
catch (MyException ex)
{
ex.MyDivideException()
}
Console.ReadLine();
}
}
}