using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SongsCloudPrototype.DAL;
using SongsCloudPrototype.Models;

namespace SongsCloudPrototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private SongsCloudContext context_;

        public UserController(SongsCloudContext dbContext)
        {
            context_ = dbContext;
        }
        public int Get()
        {
            return context_.Users.ToArray().Length;
        }
    }
}
