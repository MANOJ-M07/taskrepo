using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        static  List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="Sam",Password="sam@123",Email="sam@gamil.com"},
            new User(){UserId=2,UserName="amit",Password="amit123",Email="amit@gamil.com"},
            new User(){UserId=3,UserName="kumar",Password="kumar@123",Email="kumar@gamil.com"},
            new User(){UserId=4,UserName="anisha",Password="anisha@123",Email="anisha@gamil.com"},
            new User(){UserId=5,UserName="vidisha",Password="vidisha@123",Email="vidisha@gamil.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if(ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

    }
}
