using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenWebApp.Identity
{
    public class AppliciationContext: IdentityDbContext<User>
    {
        public AppliciationContext(DbContextOptions<AppliciationContext> options):base(options)
        {
            
        }
    }
}
