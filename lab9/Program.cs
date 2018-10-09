using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Turner turner = new Turner(500, "Turner");
            Turner turner1 = new Turner(200, "Turner 1");
            Turner turner2 = new Turner(100, "Turner 2");
            Student student = new Student(50, "Student");
            

            director.IncreaseSalary += turner.RaiseSalary;
            director.DecreaseSalary += turner.Penalty;
            director.IncreaseSalary += turner1.RaiseSalary;
            director.DecreaseSalary += turner2.Penalty;
            director.IncreaseSalary += student.RaiseSalary;
            director.DecreaseSalary += student.Penalty;

            List<Turner> employees = new List<Turner>() { turner,turner1,turner2};

            foreach(var employee in employees)
            {
                Console.WriteLine(employee.Name + " " + employee.CurrentSalary.ToString());
            }
            Console.WriteLine(student.Name + " " + student.CurrentSalary.ToString());

            director.RaiseSalary(100);
            director.Penalty(50);

            Console.WriteLine("\n");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name + " " + employee.CurrentSalary.ToString());
            }
            Console.WriteLine(student.Name + " " + student.CurrentSalary.ToString());

            Console.WriteLine("\n");

            string str = "qq    ,   ept";
            string str1 = null;

            Action<string> Count;
            Func<string, string> Op1;
            Func<string, string> Op2;
            Count = StringFunc.CharCount;
            Op1 = StringFunc.DeleteSpaces;
            Op2 = StringFunc.DeletePointers;

         
            StringFunc.ValidateString(str1,Count);
            StringFunc.ValidateString(str, Count);

           
            str1 = StringFunc.ValidateString(str, Op1);
            string str2 = StringFunc.ValidateString(str1, Op2);



            Console.WriteLine("\n");
            Console.WriteLine(str2);



        }
    }
}
