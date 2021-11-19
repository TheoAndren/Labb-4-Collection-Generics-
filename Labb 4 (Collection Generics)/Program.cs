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
                Console.WriteLine("Id {0} - Name {1} - Gender {2} - Salary {3}", s1.ID, s1.Name, s1.Gender, s1.Salary);
                Console.WriteLine("The items in the stack = " + StakEmp.Count);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            
            
            Employee employeefromstack1 = StakEmp.Pop();
            Console.WriteLine("Id {0} - Name {1} - Gender {2} - Salary {3}", employeefromstack1.ID, employeefromstack1.Name, employeefromstack1.Gender, employeefromstack1.Salary);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack2 = StakEmp.Pop();
            Console.WriteLine("Id {0} - Name {1} - Gender {2} - Salary {3}", employeefromstack2.ID, employeefromstack2.Name, employeefromstack2.Gender, employeefromstack2.Salary);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack3 = StakEmp.Pop();
            Console.WriteLine("Id {0} - Name {1} - Gender {2} - Salary {3}", employeefromstack3.ID, employeefromstack3.Name, employeefromstack3.Gender, employeefromstack3.Salary);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack4 = StakEmp.Pop();
            Console.WriteLine("Id {0} - Name {1} - Gender {2} - Salary {3}", employeefromstack4.ID, employeefromstack4.Name, employeefromstack4.Gender, employeefromstack4.Salary);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Employee employeefromstack5 = StakEmp.Pop();
            Console.WriteLine("Id {0} - Name {1} - Gender {2} - Salary {3}", employeefromstack5.ID, employeefromstack5.Name, employeefromstack5.Gender, employeefromstack5.Salary);
            Console.WriteLine("The items in the stack = " + StakEmp.Count);

            Console.WriteLine("----------------------------------");


            StakEmp.Push(E1);
            StakEmp.Push(E2);
            StakEmp.Push(E3);
            StakEmp.Push(E4);
            StakEmp.Push(E5);

            Console.WriteLine("Retrive Using Peek Method");
            Console.WriteLine("");
            
            Employee pS = StakEmp.Peek();
            Console.WriteLine(pS.ID + " " + pS.Name);
            Console.WriteLine("Toatal Items = " + StakEmp.Count);

            Employee pE = StakEmp.Peek();
            Console.WriteLine(pS.ID + " " + pS.Name);
            Console.WriteLine("Toatal Items = " + StakEmp.Count);
            Console.WriteLine("");
            
            if (StakEmp.Contains(E3))
            {
                Console.WriteLine("Employee 3 are in the stack");
            }
            else
            {
                Console.WriteLine("Employee 3 are not in the stack");
            }







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
