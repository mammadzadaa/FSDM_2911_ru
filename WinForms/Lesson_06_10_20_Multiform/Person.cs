using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_10_20_Multiform
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public bool Favorite { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
