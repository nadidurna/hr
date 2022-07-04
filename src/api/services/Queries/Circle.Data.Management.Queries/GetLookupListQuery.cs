using Circle.Data.Abstractions;
using Circle.Data.Query.Requests;
using Circle.Entities.Main;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Data.Management.Queries
{
    internal class GetLookupListQuery : IRequestHandler<GetLookupRequest, List<Lookup>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetLookupListQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Lookup>> Handle(GetLookupRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Lookup>();
            var result = await repository.GetAll(f => true, cancellationToken);
            return result;
               
        }
    }
}
