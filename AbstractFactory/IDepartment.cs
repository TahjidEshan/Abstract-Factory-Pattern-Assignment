namespace AbstractFactory
{
    interface IDepartment
    {
        string DepartmentName { get; set; }
        IDegree[] Degrees { get; set; }
        ICourse[] Courses { get; set; }
        void AddDegree();
        void AddCourse();
        IDegree CreateDegree1();
        IDegree CreateDegree2();
        ICourse CreateCourse1();
        ICourse CreateCourse2();
    }
}
