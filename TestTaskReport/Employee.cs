using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskReport
{
    public struct Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string surname, string position, DateTime birthday, int salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Position = position;
            Birthday = birthday;
            Salary = salary;
        }
    }
}
