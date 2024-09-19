using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BincomContactSessionAssignment3.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public async Task<IActionResult> Index()
        {
                var galleries = await _galleryService.GetAll(); 
                return View(galleries);
        }


        public IActionResult Upload()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(GalleryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _galleryService.AddImage(model);
                if (response.Success)
                {
                    TempData["SuccessMessage"] = response.Message;
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = response.Message;
                }
            }

            return View(model); 
        }
    }
}

