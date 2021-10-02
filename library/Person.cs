using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Person
    {
        protected string name;
        protected string password;
        protected string status;

        public Person(string name, string password, string status) {
            this.name = name;
            this.password = password;
            this.status = status;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
