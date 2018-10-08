using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class SalaryEventArgs: EventArgs
    {
        //public  delegate void SalaryStateHandler(int sum);

        //public event SalaryStateHandler AddSalary;
        //public event SalaryStateHandler RemoveSalary;

        public readonly int _delta;

        public SalaryEventArgs(int delta)
        {
            _delta = delta;
        }

    }
}
