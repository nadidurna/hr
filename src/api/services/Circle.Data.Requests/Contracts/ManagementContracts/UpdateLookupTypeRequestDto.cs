namespace Circle.Data.Requests.ManagementContracts
{
    public class UpdateLookupTypeRequestDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}