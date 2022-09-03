using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03._09._2022_C_Sharp
{
    class Peop
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string number { get; set; }

        public Peop ()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.gender = string.Empty;
            this.age = 0;
            this.number = string.Empty;
        }
        public Peop (string firstName="", string lastName="", string gender="male", int age=0, string number="")
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.number = number;
        }
    }
}
