namespace AbstractFactory
{
    class Degree1 : IDegree
    {
        public string DegreeName { get; set; }
        public string DegreeCode { get; set; }
        public IDepartment DepartmentName { get; set; }
    }
    class Degree2 : IDegree
    {
        public string DegreeName { get; set; }
        public string DegreeCode { get; set; }
        public IDepartment DepartmentName { get; set; }
    }
}
