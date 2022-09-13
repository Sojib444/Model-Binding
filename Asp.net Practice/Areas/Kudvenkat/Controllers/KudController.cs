
using Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee;
using Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee.RepositoryClass;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_Practice.Areas.Kudvenkat.Controllers
{
    [Area("Kudvenkat")]
    public class KudController : Controller
    {
        private readonly IEmpolyee _empolyee;

        public KudController(IEmpolyee empolyee)
        {
            _empolyee = empolyee;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetEmpolyee(int id)
        {
            var result = _empolyee.get(id);
            return View(result);
        }
        public IActionResult ListofEmpolyee()
        {
            var result = _empolyee.getList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateForm(Empolyee empolyee)
        {

            if(ModelState.IsValid)
            {
               Empolyee emp= _empolyee.Add(empolyee);
                return RedirectToAction("GetEmpolyee", new {id=emp.Id});
            }
            else
            {
                ViewBag.Invalid = "Form can't create Successfully";
                return View();
            }
            
            
            
        }
    }
}
