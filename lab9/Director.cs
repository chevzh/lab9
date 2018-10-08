using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab9
{
    class Director
    {
        public event EventHandler<SalaryEventArgs> IncreaseSalary;
        public event EventHandler<SalaryEventArgs> DecreaseSalary;

        public virtual void OnIncreaseSalary(SalaryEventArgs e)
        {
            Volatile.Read(ref IncreaseSalary)?.Invoke(this, e);
        }

        public virtual void OnDecreaseSalary(SalaryEventArgs e)
        {
            Volatile.Read(ref DecreaseSalary)?.Invoke(this, e);
        }

        public void RaiseSalary(int delta)
        {
            SalaryEventArgs e = new SalaryEventArgs(delta);
            OnIncreaseSalary(e);
        }

        public void Penalty(int delta)
        {
            SalaryEventArgs e = new SalaryEventArgs(delta);
            OnDecreaseSalary(e);
        }

    }
}
