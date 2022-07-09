using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


namespace Microsoft.AspNetCore.Builder
{
    public static class IServiceCollectionExtensions
    {
        public static void AddJwt(this IServiceCollection services,Settings settings)
        {
           services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(options =>
                 {
                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         ValidateAudience = false,
                         ValidateIssuer = false,
                         ValidateLifetime = true,
                         ValidateIssuerSigningKey = true,
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Jwt.Key)),
                         ClockSkew = TimeSpan.Zero
                     };
                 });
            services.AddAuthorization();
            services.AddScoped<IClaims, CurrentUserClaims>();
        }
    }
}
