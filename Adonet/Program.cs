using Adonet.Services;

namespace Adonet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employeesservice employeesservice = new Employeesservice();
            Employees employee = new Employees()
            {
                Name = "zeyno",
                Surname = "hesenova",
                Salary = 120

            };
            employeesservice.Add(employee);
                

        }
    }
}
