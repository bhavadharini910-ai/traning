using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;
using StudentApp.Models;

namespace StudentApp.ViewModels
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>()
            {
                new Student { Name="Ram", Age=20, Department="CSE", Mark1=80, Mark2=75, Mark3=90 },
                new Student { Name="Priya", Age=21, Department="IT", Mark1=85, Mark2=88, Mark3=92 },
                new Student { Name="Arun", Age=22, Department="ECE", Mark1=70, Mark2=65, Mark3=78 },
            };
        }
    }
}
