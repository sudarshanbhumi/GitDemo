using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
    class CrossJoinDemo
    {
        public static void TestCrossJoin()
        {
            var result = from d in Department.GetDepartments()
                         from e in EmployeeD.GetEmployees()
                         select new { e, d };
            var resultw = Department.GetDepartments().SelectMany(d => EmployeeD.GetEmployees(),
                                             (d, e) => new { d, e });
            foreach(var r in result)
            {
                Console.WriteLine($"{r.e.Name}=={r.d.Name}");
            }
        }
    }
}
