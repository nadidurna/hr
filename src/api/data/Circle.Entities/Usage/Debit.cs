using Circle.Common;
using Circle.Entities.Main;
using Circle.Entities.Profile;

namespace Circle.Entities.Usage
{
    [Table("Debits", Schema = "Usage")]
    public class Debit : EntityBase
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid DebitTypeId { get; set; }
        public DateTime FinishDate { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(DebitTypeId))]
        public Lookup DebitType { get; set; }
    }
}