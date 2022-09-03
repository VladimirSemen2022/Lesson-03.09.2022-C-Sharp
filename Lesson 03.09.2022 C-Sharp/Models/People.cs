using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03._09._2022_C_Sharp
{
    class People
    {
        public List<Peop> people { get; set; } = new List<Peop>();

        public People()
        {
            people = new List<Peop>();
        }

        public People (List <Peop> people)
        {
            this.people = people;
        }

        public void Show()
        {
            foreach (var item in people)
            {
                Console.WriteLine($"FirstName [{item.firstName}] LastName [{item.lastName}] Gender [{item.gender}] Age [{item.age}] Number [{item.number}]");
            }
        }
    }
}
