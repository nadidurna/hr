
using Circle.Common;

namespace Circle.Entities.Main
{
    [Table("LookupTypes", Schema = "Main")]
    public class LookupType : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }
    }
}
