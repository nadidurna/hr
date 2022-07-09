using Circle.Data.Requests.Contracts;
using Circle.Data.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Data.Services.Concretes
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMediator mediator;

        public AuthenticationService(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public Task<LoginResultDto> LoginUser(LoginRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new LoginUserRequest(data), cancellationToken);
        }
    }
}
