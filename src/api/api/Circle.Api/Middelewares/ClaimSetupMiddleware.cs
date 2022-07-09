using System.Security.Claims;

namespace Circle.Api.Middelewares
{
    internal class ClaimSetupMiddleware
    {
        private readonly RequestDelegate next;

        public ClaimSetupMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext,IClaims claims)
        {
            if (httpContext.User.Identity.IsAuthenticated)
            {
                claims.IsAuthenticated = true;
                claims.CurrentUser.Id = Guid.Parse(httpContext.User.Claims.First(f => f.Type == ClaimTypes.NameIdentifier).Value);
            }
            await next(httpContext);
        }
    }
}
