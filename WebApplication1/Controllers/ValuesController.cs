using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public List<string> GetAllDetails()
        {
            List<string> l = new List<string>();
            l.Add("V1");
            l.Add("V2");
            l.Add("V3");
            return l;
        }
    }
    
}
