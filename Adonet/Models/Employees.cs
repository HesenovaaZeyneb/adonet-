using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet.Models
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"id={Id}, name:{Name}, surname:{Surname}, salary:{Salary}";
        }
    }
}
