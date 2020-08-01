using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCtrl : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetKuKu(int id)
        {
            return "Fafa";
        }
    }
}
