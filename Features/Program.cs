﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Features.Linq;
namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name= "Scott" },
                new Employee { Id = 2, Name= "Chris" }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };
            Console.WriteLine(developers.Count());     //using linq is commented. this method is rewritten using extension.
            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name); 
            }
        }
    }
}
