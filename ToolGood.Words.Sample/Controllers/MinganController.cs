using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToolGood.Words.Sample.MinGans;

namespace ToolGood.Words.Sample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MinganController : ControllerBase
    {
        [HttpGet]
        public string Check([FromQuery]MinganCheckInput input)
        {
            return input.Text;
        }
        
        [HttpGet]
        public string Replace([FromQuery]MinganReplaceInput input)
        {
            return $"替换后的字段为:{input.Text}";
        }
    }
}