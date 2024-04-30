using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet.Abstractions
{
    internal interface IEmployees
    {
        public void Add(Employees employee);
        public void Delete(int id);
        public void Update();
        public List<Employees> Getall();
        
    }
}
