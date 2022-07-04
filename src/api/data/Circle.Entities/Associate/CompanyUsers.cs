using Circle.Common;
using Circle.Entities.Foundation;
using Circle.Entities.Profile;

namespace Circle.Entities.Associate
{
    [Table("CompanyUsers", Schema = "Associate")]
    public class CompanyUser : EntityBase
    {
        [Required]
        public Guid CompanyId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}