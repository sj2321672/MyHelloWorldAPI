using Microsoft.AspNetCore.Mvc;

namespace MyHelloWorldAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        #region GetAPI

        // 測試push
        // 回傳Hello World
        [HttpGet(Name = "GetHelloWorld")]
        public string Get()
        {
            return "Hello World";
        }

        #endregion
    }
}
