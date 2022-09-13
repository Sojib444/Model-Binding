using Microsoft.EntityFrameworkCore;

namespace Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee.contex
{
    public class EmpolyeeContecxt:DbContext 
    {
        public EmpolyeeContecxt(DbContextOptions<EmpolyeeContecxt> options)
            :base(options)
        {

        }

        public DbSet<Empolyee> empolyees { get; set; }
        
    }
}
