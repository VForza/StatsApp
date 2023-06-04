using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatsApp.Data.Mapper;
using StatsApp.Data.Models;
using StatsApp.Dtos;
using StatsApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public ActionResult<Statistics> getByDate(DateTime date)
        {
            Statistics stat = _repo.GetByDate(date);
            return Ok(stat);
        }

        [HttpGet]
        public ActionResult<IEnumerable<List<StatsResponseDto>>> getAllByDate(DateTime from, DateTime to)
        {
            //List<StatsResponseDto> stats = (List<StatsResponseDto>)_repo.GetAllByDate(from, to);
            return Ok(_repo.GetAllByDate(from, to));
        }

        [HttpDelete]
        public ActionResult DeleteAll() 
        {
            _repo.DeleteAll();
            return NoContent();
        }

        [HttpPost]
        public ActionResult<Statistics> addStatistics(StatsRequestDto stat) 
        {
            _repo.Create(stat);
            return Created("~/" , stat);
        }
    }
}
