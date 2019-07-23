using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAMS.Data;
using IAMS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IAMS.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ModelController<Person>
    {
        public PersonController(DBContext context) : base(context)
        {
        }
    }
}