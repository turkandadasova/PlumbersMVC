namespace PlumbersMVC.Models
{
    public class Employer:BaseEntity
    {
        public string Surname { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? DepartmentId { get; set; }= null!;
        public Department? Department { get; set; } = null!;
    }
}
