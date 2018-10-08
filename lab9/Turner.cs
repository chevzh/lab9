using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Turner
    {
        public int CurrentSalary{get;set;}
        public string Name { get; set; }

        public Turner(int salary, string name)
        {
            CurrentSalary = salary;
            Name = name;
            
        }

        public void RaiseSalary(object sender, SalaryEventArgs e)
        {
            CurrentSalary += e._delta;
        }

        public void Penalty(object sender, SalaryEventArgs e)
        {
            CurrentSalary -= e._delta;
        }

    }
}
