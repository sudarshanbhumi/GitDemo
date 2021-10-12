using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    class Department
    {
        public Department ()
	{
         Console.WriteLine("new branch develop is created and Some code added into department class is addedby GitDemo into develop branch");
	}
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>()
            {
               new Department(){Id=1,Name="IT"},
               new Department(){Id=2,Name="HR"},
               new Department(){Id=3,Name="Payroll"}
            };
            return departments;
        }
    }
}
