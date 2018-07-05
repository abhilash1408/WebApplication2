using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("v1/[controller]")]
    public class ClansController : Controller
    {
        private readonly IClanService<Clan> _clanService;

        public ClansController(IClanService<Clan> clanService) // Injection of IClanService
        {
            _clanService = clanService ?? throw new ArgumentNullException(nameof(clanService)); // Guard
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Clan>), 200)]
        public async Task<IActionResult> ReadAllAsync()
        {
            var allClans = await _clanService.ReadAllAsync();
            return Ok(allClans);
        }
    }
}
