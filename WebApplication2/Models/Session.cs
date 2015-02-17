using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Session
    {
        public Session()
        {
            this.Questions = new List<Question>();
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> Finish { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
