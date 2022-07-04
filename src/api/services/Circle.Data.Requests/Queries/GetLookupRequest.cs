using Circle.Entities.Main;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Data.Query.Requests
{
    public class GetLookupRequest : IRequest<List<Lookup>>
    {
    }
}