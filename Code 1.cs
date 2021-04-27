class Employee
{
spublic int EmployeeID { get; set;}
string EmployeeName { get; set; }
public void Inputvalues()
{
Console.WriteLine("Enter EmployeeID ");
EmployeeID=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter EmployeeName ");
EmployeeName=Console.ReadLine();
}
public void DisplayDetails()
{
Console.WriteLine("Enter EmployeeID " +EmployeeID);
Console.WriteLine("Enter EmployeeName " +EmployeeID);
}
public static void Main()
{
Employee emp = new Employee();
emp.Inputvalues();
emp.DisplayDetails();
Console.ReadLine();
}
}
}