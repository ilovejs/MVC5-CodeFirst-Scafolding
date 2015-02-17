using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Question
    {
        public Question()
        {
            this.Answers = new List<Answer>();
            this.Sessions = new List<Session>();
        }

        public int Id { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
