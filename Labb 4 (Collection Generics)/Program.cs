using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb_4__Collection_Generics_
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee()
            {
                ID = 111,
                Name = "David",
                Gender = "Male",
                Salary = 50000

            };
            Employee E2 = new Employee()
            {
                ID = 112,
                Name = "Albin",
                Gender = "Male",
                Salary = 10000

            };
            Employee E3 = new Employee()
            {
                ID = 113,
                Name = "Maja",
                Gender = "Female",
                Salary = 24000

            };
            Employee E4 = new Employee()
            {
                ID = 114,
                Name = "Felix",
                Gender = "Male",
                Salary = 23000

            };
            Employee E5 = new Employee()
            {
                ID = 115,
                Name = "Sara",
                Gender = "Female",
                Salary = 21000

            };
            
            
            
            
            
            Stack<Employee> StakEmp = new Stack<Employee>();

            
            StakEmp.Push(E1);
            StakEmp.Push(E2);
            StakEmp.Push(E3);
            StakEmp.Push(E4);
            StakEmp.Push(E5);

            foreach (Employee s1 in StakEmp)
            {
                Console.WriteLine("Id = {0} , Name = {1}", s1.ID, s1.Name);
                Console.WriteLine("The items in the stack = " + StakEmp.Count);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            
            
            Employee employeefromstack1 = StakEmp.Pop();
            Console.WriteLine("Id = {0} , Name = {1}", employeefromstack1.ID, employeefromstack1.Name);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack2 = StakEmp.Pop();
            Console.WriteLine("Id = {0} , Name = {1}", employeefromstack2.ID, employeefromstack2.Name);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack3 = StakEmp.Pop();
            Console.WriteLine("Id = {0} , Name = {1}", employeefromstack3.ID, employeefromstack3.Name);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack4 = StakEmp.Pop();
            Console.WriteLine("Id = {0} , Name = {1}", employeefromstack4.ID, employeefromstack4.Name);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack5 = StakEmp.Pop();
            Console.WriteLine("Id = {0} , Name = {1}", employeefromstack5.ID, employeefromstack5.Name);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            
            
            
            
            
            
            
            
            
            
            Console.ReadKey();


        }
    }









    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}
