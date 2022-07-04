using Circle.Common;
using Circle.Entities.Main;
using Circle.Entities.Profile;

namespace Circle.Entities.Usage
{
    [Table("Permits", Schema = "Usage")]
    public class Permit : EntityBase
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid PermitTypeId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsApproved { get; set; }
        public Guid ManagerId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(PermitTypeId))]
        public Lookup PermitType { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public User Manager { get; set; }
    }
}