using System;
using System.Data.Entity;

namespace IdentityUsers.Infrastructure
{
    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }

        private void PerformInitialSetup(UserDbContext context)
        {
            
        }
    }
}