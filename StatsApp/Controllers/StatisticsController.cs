using Microsoft.AspNetCore.Mvc;
using StatsApp.Data.Models;
using StatsApp.Dtos;
using StatsApp.Repositories;
using System;
using System.Collections.Generic;

namespace StatsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _repo;

        public StatisticsController(IStatisticsRepository repo)
        {
            _repo = repo;
        }

        //test method
        [HttpGet("{date}")]
        public ActionResult<Statistics> GetByDate(DateTime date)
        {
            Statistics stat = _repo.GetByDate(date);
            return Ok(stat);
        }

        [HttpGet]
        public ActionResult<List<StatsResponseDto>> GetAllByDate(DateTime from, DateTime to)
        {
            return Ok(_repo.GetAllByDate(from, to));
        }

        [HttpPost]
        public ActionResult<Statistics> AddStatistics(StatsRequestDto stat)
        {
            _repo.Create(stat);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteAll()
        {
            _repo.DeleteAll();
            return NoContent();
        }
    }
}
