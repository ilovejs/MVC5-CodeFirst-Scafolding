using System.Data.Entity.ModelConfiguration;
using WebApplication2.Models;

namespace WebApplication2.MappingContext
{
    public class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Session");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Start).HasColumnName("start");
            this.Property(t => t.Finish).HasColumnName("finish");
            this.Property(t => t.Name).HasColumnName("name");

            // Relationships
            this.HasMany(t => t.Users)
                .WithMany(t => t.Sessions)
                .Map(m =>
                    {
                        m.ToTable("UserSession");
                        m.MapLeftKey("sessionid");
                        m.MapRightKey("userid");
                    });


        }
    }
}
