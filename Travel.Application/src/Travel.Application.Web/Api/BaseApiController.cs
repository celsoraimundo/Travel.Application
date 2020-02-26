using Microsoft.AspNetCore.Mvc;

namespace Travel.Application.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
