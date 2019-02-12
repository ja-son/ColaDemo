using Questions.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questions.Models
{
    public class QuestionsRequest
    {
        public string Sort { get; set; }
        public string Tagged { get; set; }
        public string InTitle { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }

    public class QuestionsResponse
    {
        public IEnumerable<QuestionSummary> Items { get; set; }
        public bool HasMore { get; set; }
    }
}
