﻿using Microsoft.AspNetCore.Mvc;
using QandA.Data;
using QandA.Data.Models;
using System.Collections.Generic;

namespace QandA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IDataRepository _dataRepository;

        public QuestionsController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IEnumerable<QuestionGetManyResponse> GetQuestions()
        {
            var questions = _dataRepository.GetQuestions();
            return questions;
        }
    }
}
