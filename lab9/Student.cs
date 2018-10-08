using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Student
    {
        public float CurrentSalary { get; set; }
        public string Name { get; set; }

        public Student(int salary, string name)
        {
            CurrentSalary = salary;
            Name = name;
        }

        public void RaiseSalary(object sender, SalaryEventArgs e)
        {
            CurrentSalary += e._delta * 0.5f;
        }

        public void Penalty(object sender, SalaryEventArgs e)
        {
            CurrentSalary -= e._delta * 0.5f;
        }
    }
}
