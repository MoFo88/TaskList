using System.Linq;
using TaskList.EntityFramework;
using TaskList.MultiTenancy;

namespace TaskList.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TaskListDbContext _context;

        public DefaultTenantCreator(TaskListDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
