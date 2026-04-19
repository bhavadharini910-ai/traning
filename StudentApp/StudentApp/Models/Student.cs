using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace StudentApp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public int Total => Mark1 + Mark2 + Mark3;
    }
}
