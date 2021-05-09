using System;
using System.Collections.Generic;
using System.Text;

namespace HappySchool.DataModels
{
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Subs { get; set; }

    }
}
