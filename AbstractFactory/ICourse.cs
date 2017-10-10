namespace AbstractFactory
{
    interface ICourse
    {
        string CourseName { get; set; }
        string CourseId { get; set; }
        IDepartment DepartmentName { get; set; }
    }
}
