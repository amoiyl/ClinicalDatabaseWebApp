using ClinicalWebapp.Areas.Identity.Data;
using ClinicalWebapp.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ClinicalWebapp.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
