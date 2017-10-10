using System;
namespace AbstractFactory
{
    class Course1 : ICourse
    {
        public string CourseName { get; set; }
        public string CourseId { get; set; }
        public IDepartment DepartmentName { get; set; }
    }
    class Course2 : ICourse
    {
        public string CourseName { get; set; }
        public string CourseId { get; set; }
        public IDepartment DepartmentName { get; set; }
    }
}
