using PartialClass1.PartialClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Eat();
            person.Move();

            Console.ReadKey();
        }
    }
}
