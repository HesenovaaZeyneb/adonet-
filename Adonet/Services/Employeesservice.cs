using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adonet.Context;

namespace Adonet.Services
{
    internal class Employeesservice : IEmployees
    {
        AppDbContext appdb;
        public Employeesservice()
        {
            appdb = new AppDbContext();
        }

        public void Add(Employees employee)
        {
            string command = $"insert into Employees values ('{employee.Id}',' {employee.Name}','{employee.Surname},'{employee.Salary}')";
              int result=appdb.NonQuery(command);

        }

        public void Delete(int id)
        {
            string command = $"delete from Employees where Id={id}";
          int result=appdb.NonQuery(command);
        }

        public List<Employees> Getall()
        {
            List<Employees> list = new List<Employees>();
              string query = $"select * from Employees ";
              foreach(DataRow item in appdb.GetTable(query).Rows)
            {
                    Employees employee = new Employees()
                    {
                        Id = int.Parse(item["Id"].ToString()),
                        Name = item["Name"].ToString(),
                        Surname = item["Surname"].ToString(),
                        Salary = decimal.Parse(item["Salary"].ToString())
                    };
                   list.Add(employee);
               

                } 
            return list;

        }

        public void Update(string name , int id)
        {
            string query = $"update Employees set name={name} where id={id}";
            appdb.NonQuery(query);


        }
        

       
        
    }
}
