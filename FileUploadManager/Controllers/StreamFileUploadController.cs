using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using FileUploadManager.Interfaces;

namespace FileUploadManager.Controllers
{
    public class StreamFileUploadController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        public StreamFileUploadController(IWebHostEnvironment environment)
        {
            _hostEnvironment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Path = Path.Combine(_hostEnvironment.WebRootPath, "UploadedFiles");
            return View();
        
        }
    }
}
