using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPNETCoreWebAPIJWTTutorial.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "4fc6cb20-a896-4117-b2fc-13f83de5a35c",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "96753bf5-0bc4-4216-ba2c-7a814ab67f9d",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}
