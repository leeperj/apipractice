using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day33WebAPIsDay3.Models;
using System.Net.Http;

namespace Day33WebAPIsDay3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var catBreeds = CatAPIMethods.CatBreeds().Result;
            return View(catBreeds);
        }

      
       public IActionResult RandomCatByBreed()
        {
            var catImages = CatAPIMethods.GetBreedImages().Result;
            return View(catImages);
        }      
        
      
    }
}
