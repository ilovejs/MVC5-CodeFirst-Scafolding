using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Answer
    {
        public Answer()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public Nullable<int> QuestionId { get; set; }
        
        public virtual Question Question { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
