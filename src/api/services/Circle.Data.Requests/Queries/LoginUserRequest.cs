using Circle.Data.Requests.Contracts;
using MediatR;

namespace Circle.Data.Requests.Queries
{
    public class LoginUserRequest : IRequest<LoginResultDto>
    {
        public LoginUserRequest(LoginRequestDto data)
        {
            Data = data;
        }

        public LoginRequestDto Data { get; }
    }
}
