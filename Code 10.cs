using System.IO;
using System;

class Class4
{
    public static void Main()
    {
        int x = 1;
        int y =0, z = 0;
        int []a = new int[1];
        try
        {
            a[1] = 1;
            Console.WriteLine(y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Some error have occured");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Some error have occured");
        }
        finally
        {
            Console.WriteLine("I am in finally block");
        }
        Console.ReadLine();
        
    }
}