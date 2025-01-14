using System.Numerics;

namespace PlumbersMVC.Models
{
    public class Department:BaseEntity
    {
        public IEnumerable<Employer> Employers { get; set; }
    }
}
