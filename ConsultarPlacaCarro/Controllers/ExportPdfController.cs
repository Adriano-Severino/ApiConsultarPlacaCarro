using Microsoft.AspNetCore.Mvc;

namespace ConsultarPlacaCarro.Controllers
{
    public class ExportPdfController : Controller
    {
        public IActionResult ExportPdf()
        {
            //return File(bytes, "application/pdf");
            return View();
        }
    }
}
