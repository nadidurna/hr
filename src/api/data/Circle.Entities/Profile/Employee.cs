using Circle.Common;
using Circle.Common.Enums;
using Circle.Entities.Main;

namespace Circle.Entities.Profile
{ 
    [Table ("Employees",Schema= "Profile")]
    public class Employee : EntityBase
    {

        [MaxLength(24)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(24)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(36)]
        [Required]
        public string UserName { get; set; }
       
        public Guid CityId { get; set; }
        
        public Guid CountryId { get; set; }
     
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [MaxLength(64)]
        public string EMail { get; set; }
       
        [MaxLength(24)]
        public string Phone { get; set; }
        public Gender Gender { get; set; }
      
        [Required]
        [MaxLength(64)]
        public string Password { get; set; }
        [Required]
        public string PasswordHash { get; set; }

        [MaxLength(36)]
        public string VerificationId { get; set; }

        public Guid TypeId { get; set; }
        public byte[] Photo { get; set; }
        
        [ForeignKey(nameof(TypeId))]
        public Lookup Type { get; set; }

        [ForeignKey(nameof(CityId))]
        public Lookup City { get; set; }
        [ForeignKey(nameof(CountryId))]
        public Lookup Country { get; set; }
       

    }
}
