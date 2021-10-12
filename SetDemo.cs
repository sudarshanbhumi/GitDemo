using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

namespace firstWebApp
{
    public class SetDemo
    {
        public static void TestWorker()
        {
            // IEnumerable<Worker> workers = Worker.getWorkers().Distinct(new SetComparer());
            //var workers = Worker.getWorkers().Select(x => new { x.Id, x.Name }).Distinct();
            List<Worker> workers1 = new List<Worker>()
            {
                new Worker(){Id=1001,Name="Siva",Salary=10000},
                new Worker(){Id=1001,Name="Siva",Salary=10000},
                new Worker(){Id=1002,Name="Shankar",Salary=20000}
            };
            List<Worker> workers2 = new List<Worker>()
            {
                new Worker(){Id=1001,Name="Siva",Salary=10000},
                new Worker(){Id=1003,Name="Sarayu",Salary=10000},
                new Worker(){Id=1002,Name="Shankar",Salary=20000}
            };

            var workerunion = workers1.Union(workers2);
            var workerunion1 = workers1.Select(w1 => new { w1.Id, w1.Name }).Union(workers2.Select(w2=> new { w2.Id, w2.Name }));

            foreach (var w in workerunion1)
            {
                Console.WriteLine($"{w.Id} \t {w.Name}");
            }
        }
    }

    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static List<Worker>  getWorkers()
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker(){Id=1001,Name="Siva",Salary=10000},
                new Worker(){Id=1001,Name="Siva",Salary=10000},
                new Worker(){Id=1002,Name="Shankar",Salary=20000}
            };
            return workers;
        }
    }

    public class SetComparer : IEqualityComparer<Worker>
    {

        public bool Equals (Worker x,  Worker y)
        {
            return x.Id==y.Id &&  x.Name==y.Name;
        }

       
        public int GetHashCode( Worker obj)
        {
           return obj.Id.GetHashCode()^obj.Name.GetHashCode();
        }
    }
}