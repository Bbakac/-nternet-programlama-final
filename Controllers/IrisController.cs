using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using IrisReadingApp.Models;

namespace IrisReadingApp.Controllers
{
    public class IrisController : Controller
    {
        public IActionResult Index()
        {
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "iris.json");
            var jsonData = System.IO.File.ReadAllText(jsonFilePath);
            List<Iris>? irisList = JsonConvert.DeserializeObject<List<Iris>>(jsonData);

            return View(irisList);
        }
    }
}
