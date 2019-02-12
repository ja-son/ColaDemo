using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questions.Models.Types
{
    public class QuestionSummary
    {
        public int Id { get; set; }
        public bool IsAnswered { get; set; }
        public long ViewCount { get; set; }
        public int AnswerCount { get; set; }
        public int Score { get; set; }
        public DateTime LastActivityDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; }
        public int UserId { get; set; }
    }
}
