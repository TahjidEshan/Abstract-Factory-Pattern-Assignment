namespace AbstractFactory
{
    interface IDegree
    {
        string DegreeName { get; set; }
        string DegreeCode { get; set; }
        IDepartment DepartmentName { get; set; }
    }
}
