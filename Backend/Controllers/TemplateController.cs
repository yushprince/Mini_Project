﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using _Backend.Data;
using _Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _Backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public TemplateController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IList<Template> Get()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _dbContext.Templates.Where(x => x.UserId == userId).ToList();
        }
    }
}
