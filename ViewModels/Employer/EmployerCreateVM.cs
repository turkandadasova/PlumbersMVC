using PlumbersMVC.Models;

namespace PlumbersMVC.ViewModels.Employer
{
    public class EmployerCreateVM
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? DepartmentId { get; set; } = null!;
       
    }
}
