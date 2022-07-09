using Circle.Data.Requests.Contracts;

namespace Circle.Data.Services.Abstractions
{
    public interface IAuthenticationService
    {
        Task<LoginResultDto> LoginUser(LoginRequestDto data, CancellationToken cancellationToken);
    }
}
