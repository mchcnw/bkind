
using Microsoft.AspNetCore.Mvc;
namespace WebApplication
{
    
    public class HomeController:Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}