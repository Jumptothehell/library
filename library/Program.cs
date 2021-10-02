using System;

namespace library
{
    enum ListFirstpage {Login = 1, Register }
    enum PersonType {Student = 1, Employee }
    class Program
    {
        static ListRegister personList;
        static void Main(string[] args)
        {
            PreparePersonList();
            FirstPage();
        }
        static void PreparePersonList() {
            Program.personList = new ListRegister();
        }
        static void FirstPage() {
            Console.WriteLine("Welcome to Digital Libraly");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("Select Menu: ");
            InputListFirstPage();
        }
        static void InputListFirstPage()
        {
            ListFirstpage Keymenu = (ListFirstpage)(int.Parse(Console.ReadLine()));
            PreFirstPage(Keymenu);
        }
        static void PreFirstPage(ListFirstpage Keymenu)
        {
            if (Keymenu == ListFirstpage.Login)
            {

            }
            else if (Keymenu == ListFirstpage.Register)
            {
                Console.Clear();

                int totalregister = TotalNewRegister();
                InputNewRegisterFromKeyboard(totalregister);
            }
        }
        static int TotalNewRegister() {
            Console.WriteLine("Input total new Register: ");
            return int.Parse(Console.ReadLine());
        }
        static void InputNewRegisterFromKeyboard(int totalRegister) {
            for (int i = 0; i < totalRegister; i++)
            {
                Console.Clear();

                RegisterStudent student = RegisterNewStudent();
                RegisterEmployee employee = RegisterNewEmployee();
                Pro
            }
        }
        static void RegisterHeader() {
            Console.WriteLine("Register new Person");
            Console.WriteLine("---------------------");
        }
        static void ShowRegisterPage() {
            Console.Clear();
            RegisterHeader();
            InputName();
            InputPassword();
            string CodeType = InputUserType();
            if (CodeType == "1")
            {
                InputStudentID();
            }
            else if (CodeType == "2")
            {
                InputEmployeeID();
            }
        }
        static string InputName() {
            Console.WriteLine("Input name: ");
            return Console.ReadLine();
        }
        static string InputPassword() {
            Console.WriteLine("Input Password: ");
            return Console.ReadLine();
        }
        static string InputUserType() {
            Console.WriteLine("Input User Type 1 = Student, 2 = Employee: ");
            return Console.ReadLine();
        }
        static string InputStudentID() {
            Console.WriteLine("Student ID: ");
            return Console.ReadLine();
        }
        static string InputEmployeeID() {
            Console.WriteLine("Employee ID: ");
            return Console.ReadLine();
        }
        static RegisterStudent RegisterNewStudent() {
            return new RegisterStudent(InputName(), InputPassword(), InputUserType(), InputStudentID());
        }
        static RegisterEmployee RegisterNewEmployee() {
            return new RegisterEmployee(InputName(), InputPassword(), InputUserType(), InputEmployeeID());
        }
        static void ShowGetListPerson() {
            Console.Clear();
            Program.personList.FetchPersonList();
        }
        static void LoginPage() {
        
        }
    }
}
