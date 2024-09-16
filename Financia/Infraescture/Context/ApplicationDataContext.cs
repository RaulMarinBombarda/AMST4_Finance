using Financia.Models;
using Microsoft.EntityFrameworkCore;

namespace Financia.iNFRAESCTURE.Context
{
    public class ApplicationDataContext: DbContext
    {
        
    
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> opitions) : base(opitions)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
