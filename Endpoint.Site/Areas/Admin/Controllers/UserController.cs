using Microsoft.AspNetCore.Mvc;
using ProjectOne.Application.Services.Users.Queries.GetUsers;

namespace Endpoint.Site.Areas.Admin.Controllers
{
   
    public class UserController : Controller
    {
        private readonly IGetUserService _getUserService;

        public UserController( IGetUserService getUserService)
        {
            _getUserService = getUserService;
        }
        [Area("Admin")]
        public IActionResult Index(string serchKey,int page=1)
        {
            return View(_getUserService.Execute(new RequestGetUserDto
            {
                Page = page,
                SearchKey = serchKey
            }));
        }
    }
}
