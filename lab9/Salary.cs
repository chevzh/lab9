using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Salary
    {
        public  delegate void SalaryStateHandler(int sum);

        public event SalaryStateHandler AddSalary;
        public event SalaryStateHandler RemoveSalary;


    }
}
