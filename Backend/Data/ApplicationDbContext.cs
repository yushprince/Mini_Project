using _Backend.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace _Backend.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MailingList> MailingLists { get; set; }
        public DbSet<MailingListContactLink> MailingListContacts { get; set; }
        public DbSet<Template> Templates { get; set; }
    }
}
