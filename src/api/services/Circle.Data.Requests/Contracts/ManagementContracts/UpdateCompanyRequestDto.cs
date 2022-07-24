namespace Circle.Data.Requests.ManagementContracts
{
    public class UpdateCompanyRequestDto
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}