using Microsoft.AspNetCore.Mvc;
using StatsApp.Data.Models;
using StatsApp.Dtos;
using StatsApp.Mappers;
using StatsApp.Services;
using System;
using System.Collections.Generic;

namespace StatsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _service;

        public StatisticsController(IStatisticsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<StatisticsResponseDto>> GetAllByDate(DateTime from, DateTime to)
        {
            if (to < from)
            {
                return BadRequest("Wrong date range: date \"to\" must be later than \"from\" ");
            }
            return Ok(_service.GetAllByDate(from, to));
        }

        [HttpPost]
        public ActionResult<Statistics> AddStatistics(StatisticsRequestDto stat)
        {
            _service.CreateStatistics(stat);
            return Ok(StatisticsMapper.RequestToResponse(stat));
        }

        [HttpDelete]
        public ActionResult DeleteAll()
        {
            _service.DeleteAll();
            return NoContent();
        }
    }
}
