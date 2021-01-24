using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID = 101, Name = "Mark", Experience = 4 });
        empList.Add(new Employee() { ID = 102, Name = "Marshall", Experience = 2 });
        empList.Add(new Employee() { ID = 103, Name = "Axel", Experience = 6 });
        empList.Add(new Employee() { ID = 104, Name = "Eden", Experience = 10 });
        empList.Add(new Employee() { ID = 105, Name = "Mark", Experience = 1 });

        /* We are using lambda function which behind the scences creates an instance of delegate and 
        passes a function (func that contains the logic we want like promoting employee on the basis of experience) as a parameter. 
        Then passes delegate reference variable as parameter to the method we've invoked */
        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
    }
}


delegate bool isPromotable(Employee empl);


//Using delegate we can reuse the class without changing its logic. Logic is provided by the user who uses this class
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }

    //We pass delegate as parameter. Function inside function
    public static void PromoteEmployee(List<Employee> employeeList, isPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}