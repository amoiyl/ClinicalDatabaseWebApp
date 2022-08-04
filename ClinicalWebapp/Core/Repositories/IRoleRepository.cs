using ClinicalWebapp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace ClinicalWebapp.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
