using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Questions.Models;
using Questions.Models.Types;
using Questions.Services;

namespace Questions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionDataService dataService;

        public QuestionsController(IQuestionDataService questionDataService)
        {
            dataService = questionDataService;
        }

        // GET api/questions
        [HttpGet]
        public ActionResult<QuestionsResponse> Get([FromQuery] QuestionsRequest req)
        {
            var questions = dataService.Search(req).Select(x => new QuestionSummary
            {
                Id = x.Id,
                AnswerCount = x.AnswerCount,
                CreationDate = x.CreationDate,
                IsAnswered = x.IsAnswered,
                LastActivityDate = x.LastActivityDate,
                LastEditDate = x.LastEditDate,
                Score = x.Score,
                Tags = x.Tags,
                Title = x.Title,
                UserId = x.UserId,
                ViewCount = x.ViewCount
            });

            return new QuestionsResponse
            {
                Items = questions
            };
        }

        // GET api/questions/5
        //[HttpGet("{id}")]
        //public ActionResult<Question> Get(int id)
        //{
        //    return new Question();
        //}

        // POST api/questions
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/questions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/questions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
