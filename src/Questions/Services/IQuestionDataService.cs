using Questions.Models;
using Questions.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questions.Services
{
    public interface IQuestionDataService
    {
        IEnumerable<Question> Search(QuestionsRequest query);
    }
}
