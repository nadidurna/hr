using Circle.Common;

namespace Circle.Entities.Foundation
{
    [Table("Companies", Schema =("Foundation"))]
    public class Company : EntityBase
    {
        [Required]
        [MaxLength(24)]
        public string CompanyName { get; set; }
        [MaxLength(120)]
        public string Description { get; set; }
        [MaxLength(120)]
        public string Address { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
    }
}