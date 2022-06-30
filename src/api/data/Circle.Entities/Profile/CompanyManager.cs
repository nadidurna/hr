using Circle.Common.Enums;
using Circle.Entities.Main;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Circle.Entities.Profile
{
    [Table("CompanyManagers", Schema = "Profile")]
    public class CompanyManager  //EntityBase den inheritance
    {
        [Required]
        [MaxLength(24)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(24)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(16)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(60)]
        public string EMail { get; set; }
        [Required]
        [MaxLength(60)]
        public string Password { get; set; }
        [MaxLength(32)]
        public string PasswordHash { get; set; }
        [MaxLength(60)]
        public string VerificationId { get; set; }

        public Guid TypeId { get; set; }

        public Guid CompanyId { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
        [MaxLength(120)]
        public string Address { get; set; }
        public Guid CountryId { get; set; }
        public Guid CityId { get; set; }

        public Gender Gender { get; set; }
        public byte[] Photo { get; set; } 
        [ForeignKey(nameof(TypeId))]
        public Lookup Type { get; set; } 

        [ForeignKey(nameof(CompanyId))]
        public Lookup Company { get; set; }
        [ForeignKey(nameof(CityId))]
        public Lookup City { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Lookup Country { get; set; }
    }
}