using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class RegisterStudent: Person
    {
        public string StudentID;
        public RegisterStudent(string name, string password, string status, string StudentID):base(name, password, status)
        {
            this.StudentID = StudentID;
        }
    }
}
