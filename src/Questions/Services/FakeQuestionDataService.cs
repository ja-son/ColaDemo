using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questions.Models;
using Questions.Models.Types;

namespace Questions.Services
{
    internal class FakeQuestionDataService : IQuestionDataService
    {
        public IEnumerable<Question> Search(QuestionsRequest query)
        {
            return new List<Question>(new Question[]
            {
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "How to open pop-up window in ASP.NET web application?",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "Not able to get QueryString in next page after redirecting to another page using Modal",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "Dynamically assign value to a Property",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "Identity server 4 and api application",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "How to show RSS as pop-up?",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "After impersonation authentication screen keeps popping up in my ASP.NET Application",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "DropDownList lose index after PostBack",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "How to open pop-up window in ASP.NET web application?",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "How to open pop-up window in ASP.NET web application?",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                },
                new Question
                {
                    Id = 1223213,
                    AnswerCount = 2,
                    Title = "How to open pop-up window in ASP.NET web application?",
                    CreationDate = new DateTime(1341156509, DateTimeKind.Utc),
                    Description = @"I'm using a GridView in ASP.NET web application and want to open something like a ""new form"" (like in Windows Forms application) which will contain the selected GridView row data. I don't have issues selecting the row and the data, I just want to know how to open a new pop-up window, or secondary page or something like that, and how to pass the information to newly opened pop-up.",
                    IsAnswered = true,
                    LastActivityDate = new DateTime(1549102642, DateTimeKind.Utc),
                    LastEditDate = new DateTime(1549102642, DateTimeKind.Utc),
                    UserId = 23232,
                    ViewCount = 12172,
                    Score = 0,
                    Tags = new List<string>(new string[] { "c#", "asp.net", "web", "popup" })
                }
            });
        }
    }
}
