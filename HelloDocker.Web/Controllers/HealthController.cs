using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AQHG.DX.MaintenanceForm.Web.Controllers
{
    [Route("[controller]")]
    public class HealthController : Controller
    {
        private static readonly HttpClient _httpClient;

        static HealthController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet]
        public IActionResult Get() => Ok("ok");

        //或者使用fabio进行健康检查
        //[Route("")]
        //[HttpGet]
        //public async Task<HttpResponseMessage> GetWithFabio() => await _httpClient.GetAsync("http://127.0.0.1:9998/health");
    }
}
