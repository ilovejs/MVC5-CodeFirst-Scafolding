using System.Data.Entity.ModelConfiguration;
using WebApplication2.Models;

namespace WebApplication2.MappingContext
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Fn)
                .HasMaxLength(50);

            this.Property(t => t.Ln)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Fn).HasColumnName("fn");
            this.Property(t => t.Ln).HasColumnName("ln");

            // Relationships
            this.HasMany(t => t.Answers)
                .WithMany(t => t.Users)
                .Map(m =>
                {
                    m.ToTable("UserAnswer");
                    m.MapLeftKey("userid");
                    m.MapRightKey("answerid");
                });


        }
    }
}
