using Microsoft.AspNet.Identity.EntityFramework;

namespace AngularAuthDemo.Api
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthConnString")
        {

        }
    }
}
