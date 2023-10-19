using Microsoft.AspNetCore.Mvc;

using programming009.WebAppMvc.Models;

namespace programming009.WebAppMvc.Controllers
{

    /*
     * 
     *    chrome  ------>
     *   +---------+          +---------+
     *   |         |  GET   ^ |         |
     *   |   UI    |  <---  | |   Ctrl  |
     *   |         |  POST  | |         |
     *   |         |  --->  | |         |
     *   |         |  POST  | |         |
     *   +---------+          +---------+
     *                    
     *   
     *   
     */


    public class PersonController : Controller
    {
        [TempData]
        public string Message { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = Message;
            return View();
        }

        [HttpPost]
        public IActionResult SavePerson(PersonModel model)
        {
            Message = $"{model.Name} succesfully saved";
            return RedirectToAction("Index");
        }
    }
}
