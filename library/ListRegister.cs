using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ListRegister
    {
        private List<Person> PersonList;

        public ListRegister() {
            this.PersonList = new List<Person>();
        }
        public void AddRegister(RegisterEmployee Person) {
            this.PersonList.Add(Person);
        }
        public void FetchPersonList() {
            Console.WriteLine("List Person");
            Console.WriteLine("---------------");
            foreach (Person person in this.PersonList) {
                if (person is RegisterStudent)
                {
                    Console.Write("Name: { 0} \nType: Student \n", person.GetName());
                }
                else if (person is RegisterEmployee)
                {
                    Console.WriteLine("Name: {0} \nType: Teacher \n", person.GetName());
                }
            }
        }
    }
}
