using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hw2.hw4.hw4_1.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public float Salary { get; set; }

        public Employee(int Id, string Name, int PhoneNumber, float Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Salary = Salary;
        }

        public static Employee operator +(Employee a, float b)
        {
            a.Salary += b;
            return a;
        }

        public static Employee operator -(Employee a, float d)
        {
            a.Salary -= d;
            return a;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            return a.Salary == b.Salary;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !(a.Id == b.Id 
                && a.Name == b.Name 
                && a.PhoneNumber == b.PhoneNumber
                && a.Salary == b.Salary);
        }

        public static bool operator <(Employee a, Employee r)
        {
            return a.Salary < r.Salary;
        }

        public static bool operator >(Employee a, Employee h)
        {
            return a.Salary > h.Salary;
        }

    }
}


