namespace AbstractFactory
{
    class CSE : IDepartment
    {
        public string DepartmentName { get; set; }
        public IDegree[] Degrees { get; set; }
        public ICourse[] Courses { get; set; }
        public void AddDegree() { }
        public void AddCourse() { }
        public IDegree CreateDegree1()
        {
            return new Degree1();
        }
        public IDegree CreateDegree2()
        {
            return new Degree2();
        }
        public ICourse CreateCourse1()
        {
            return new Course1();
        }
        public ICourse CreateCourse2()
        {
            return new Course2();
        }
    }
}
