using System;

/* Object oriented programming consists of three main ideas:
 * 1. Abstraction or Encapsulation
 * 2. Inheritance - reusability of classes/enables more abstraction 
 * 3. Polymorphism - overloading and overriding
 * From Chapter 5 : SOLID -
 *  Single Responsibility
 *  Open-Close
 *  Lishkov Substitution Principle
 *  Interface Segregation
 *  Dependency
 */

/* Namespaces help in organizing code: a name space defines a declaration space 
 * that contains types - so C# namespaces are equivalent to Java (Python) imports.
 * Java example - 
 * import java.util.*;
 * ...
 * Inputstream x = ...
 * 
 * Note that we may be tempted to think C has namespace functionality using #include <stdio.h>
 * NO!  Because all #include does is tell the preprocessor to simply substitute the contents of
 * <stdio.h> - we are not defining a declaration space.  Scoping in C is limited to only {}.  OOP languages
 * hve a more robust definition of scope.
 */

namespace chapter_04 { 
    class Employee {
        /* EmployeeId Functionality:
           Start with an employeeId of 1, everytime an employee is added, they are assigned a unique increasing id.
           Assumption:  the first employee added has the employee id 1
           Functionality specification =>
           Second employee added has the employee id 2
           ....
           Problem solving methodology:
           Step 1: Understand the problem [DONE: UNIQUE!]
           Step 2: Devise a plan [C# (programming) functionality: static ]
           Step 3: Carryout the plan [Algorithm or step-by-step procedure]
           Step 4: Check our answer [programming:  testing!]
         */

        private static int employeeCount = 1; // Instead of initializing here, we could have a static constructor
        private int employeeId;
        private string firstName;
        private string lastName;

        public Employee() {

        }

        public Employee(string firstName, string lastName) {            
            this.employeeId = employeeCount;
            this.firstName = firstName;
            this.lastName = lastName;
            employeeCount += 1;
        }

        /* Accessors (get methods) and Modifiers (set methods):
         * implement these methods as EXPRESSION BODY MEMBERS
         */
        public string FirstName { // notice:  F is uppercase, this is *different* from firstName
            get => firstName;
            set => firstName = value; // value can be thought of as the argument to the set method
        }
        public int EmployeeId {
            get => employeeId;
        }
        
    }


    class Program {
        /* Swap: difference between call-by-value (default: only copies of arguments passed to methods)
           as opposed to call-by-reference
        */
        static void Swap(ref int a, ref int b) { // Swap a and b, ref keyword indicates call-by-reference
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args) {
            Employee[] myEmployees = new Employee[2];
            myEmployees[0] = new Employee("Jake", "B");
            myEmployees[1] = new Employee("Bharath", "M");            
            // Iterators : looping over ADTs (Abstract Data Types)
            foreach (Employee e in myEmployees) {  
                Console.WriteLine(e.EmployeeId);
            }
            int a = 3;
            int b = 5;            
            Console.WriteLine($"Before swapping: a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After swapping: a={a}, b={b}");
        }
    }
}
