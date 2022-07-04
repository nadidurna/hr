using Circle.Common;
using Circle.Common.Enums;
using Circle.Entities.Main;

namespace Circle.Entities.Profile
{
    [Table("Users", Schema = ("Profile"))]
    public class User : EntityBase
    {
        [Required]
        [MaxLength(24)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(36)]
        public string Email { get; set; }
        [Required]
        [MaxLength(36)]
        public string Password { get; set; }
        [Required]
        [MaxLength(60)]
        public string PasswordHash { get; set; }
        [Required]
        [MaxLength(36)]
        public string VerificationId { get; set; }
        public UserType Type { get; set; }
        public Gender Gender { get; set; }
        [MaxLength(120)]
        public string Address { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CityId { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Lookup Country { get; set; }
        [ForeignKey(nameof(CityId))]
        public Lookup City { get; set; }
        
    }
}