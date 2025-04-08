using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedExample2
{
    class Employee
    {
        protected string Employee_Name;
        protected int Employee_ID;
        protected string Employee_Address;

        protected void Show()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine($"Employee name is : {Employee_Name}");
            Console.WriteLine($"Employee id is : {Employee_ID}");
            Console.WriteLine($"Employee name is : {Employee_Address}");
        }
    }
    class person: Employee
    {
       public person ()
        {
            Employee_Name = "Shubham";
            Employee_ID = 1243;
            Employee_Address = "Pune";
        }
        public void DisplayDetails()
        {
            Show();
        }
    }
    internal class Protectedaccessmodifier
    {
        static void main ()
        {
            person emp = new person();
            emp.DisplayDetails();
        }
    }
}
