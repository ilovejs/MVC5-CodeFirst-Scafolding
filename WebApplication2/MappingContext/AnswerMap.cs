using System.Data.Entity.ModelConfiguration;
using WebApplication2.Models;

namespace WebApplication2.MappingContext
{
    public class AnswerMap : EntityTypeConfiguration<Answer>
    {
        public AnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Answer");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.Code).HasColumnName("code");
            this.Property(t => t.Content).HasColumnName("content");
            this.Property(t => t.QuestionId).HasColumnName("questionid");

            // Relationships
            this.HasOptional(t => t.Question)
                .WithMany(t => t.Answers)
                .HasForeignKey(d => d.QuestionId);

        }
    }
}
