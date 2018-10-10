using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Features.Linq;
namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            //Writing the body in lambda exp
            Func<int, int, int> sub = (x, y) =>
            {
                int temp = x - y;
                return temp;
            };
            Console.WriteLine(square(add(5,6)));
            Console.WriteLine(square(sub(8,4)));
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name= "Scott" },
                new Employee { Id = 2, Name= "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            foreach (var employee in developers.Where(
                             e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }
            //Console.WriteLine(developers.Count());     //using linq is commented. this method is rewritten using extension.
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name); 
            //}
        }
    }
}
