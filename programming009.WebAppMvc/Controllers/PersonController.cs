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
     *   client                 Server
     *   
     *  client side            s erver side   
     *  validation              validation
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
            //server side validation
            if (ModelState.IsValid == false)
            {
                return View("Index", model);
            }

            //bool result = Validate(model);

            //if (result == false)
            //{
            //    return View("Index", model);
            //}

            Message = $"{model.Name} succesfully saved";

            return RedirectToAction("Index");
        }
    }
}
