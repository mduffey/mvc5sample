using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApp.Repositories
{
    public class StudentRepository
    {
        private List<Student> _students = new List<Student>
        {
            new Student { Name = "John" },
            new Student { Name = "Roxanne" },
            new Student { Name = "Carol" },
            new Student { Name = "Adam" },
            new Student { Name = "Michael" },
            new Student { Name = "Justin" },
            new Student { Name = "Kim" },
        };

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetOne(string name)
        {
            return _students.First(s => s.Name == name);
        }
    }
}