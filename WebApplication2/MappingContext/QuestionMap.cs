using System.Data.Entity.ModelConfiguration;
using WebApplication2.Models;

namespace WebApplication2.MappingContext
{
    public class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Question");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Text).HasColumnName("text");

            // Relationships
            this.HasMany(t => t.Sessions)
                .WithMany(t => t.Questions)
                .Map(m =>
                    {
                        m.ToTable("SessionQuestion");
                        m.MapLeftKey("questionid");
                        m.MapRightKey("sessionid");
                    });


        }
    }
}
