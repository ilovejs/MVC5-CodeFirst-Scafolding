using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApplication2.MappingContext;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public partial class Mvc2Context : DbContext
    {
        //static Mvc2Context()
        //{
        //    Database.SetInitializer<Mvc2Context>(new DropCreateDatabaseIfModelChanges<Mvc2Context>());
        //}

        public Mvc2Context()
            : base("Name=MVC2")
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<User> Users { get; set; }
        
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    //
        //    modelBuilder.Configurations.Add(new AnswerMap());
        //    modelBuilder.Configurations.Add(new QuestionMap());
        //    modelBuilder.Configurations.Add(new SessionMap());
        //    modelBuilder.Configurations.Add(new UserMap());
        //}
    }
}
