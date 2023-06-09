﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveyTask.Model;
using SurveyTask.Service;

namespace SurveyTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyDataController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        public SurveyDataController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        

        [HttpPost]
        [Route("generate-report")]
        public async Task<IActionResult> GenerateReport(ReportDto reportDto)
        {
            var result =await _surveyService.GenerateReport(reportDto);
            return Ok(result);
        }

    }
}
