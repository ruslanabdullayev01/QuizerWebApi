using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quizer.Core.Services;
using Quizer.Models.DTOs.Questions.Create;
using Quizer.Models.DTOs.Questions.GetById;

namespace Quizer.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService questionService;

        public QuestionsController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        [HttpGet]
        public IActionResult Create(QuestionCreateDto request)
        {
            var response = questionService.Create(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var response = questionService.GetById(id);
            return Ok(response);
        }
    }
}
