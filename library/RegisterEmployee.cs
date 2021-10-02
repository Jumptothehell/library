using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class RegisterEmployee: Person
    {
        public string EmployeeID;
        public RegisterEmployee(string name, string password, string status, string EmployeeID): base(name, password, status)
        {
            this.EmployeeID = EmployeeID ;
        }
    }
}
