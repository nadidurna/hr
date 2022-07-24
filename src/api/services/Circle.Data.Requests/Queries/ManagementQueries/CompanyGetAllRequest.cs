using Circle.Data.Requests.ManagementContracts;
using MediatR;

namespace Circle.Data.Requests.Queries.ManagementQueries
{
    public class CompanyGetAllRequest : IRequest<List<CompanyDto>> { }
}